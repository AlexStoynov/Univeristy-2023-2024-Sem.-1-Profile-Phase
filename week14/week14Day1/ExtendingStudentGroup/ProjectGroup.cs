using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace ExtendingStudentGroup
{
    public class ProjectGroup
    {
        private string groupName;
        private int groupId;
        private List<Member> members;

        public ProjectGroup(string name)
        {
            this.groupName = name;
            members = new List<Member>();
            using (SqlConnection sqlConnection = GetConnection())
            {
                try
                {
                    string sql = $"INSERT INTO dbo.project_group (GroupName) VALUES (@name); SELECT SCOPE_IDENTITY();";
                    SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@name", name);
                    sqlConnection.Open();
                    groupId = Convert.ToInt32(sqlCommand.ExecuteScalar());
                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString()); }
            }
        }

        public string GroupName { get { return this.groupName; } }
        public ReadOnlyCollection<Member> Members { get { return this.members.AsReadOnly(); } }

        public void AddMember(string name)
        {
            Member member = new Member(name);
            members.Add(member);
            using (SqlConnection sqlConnection = GetConnection())
            {
                try
                {
                    string sql = $"INSERT INTO dbo.Member (MemberName, GroupId) VALUES ('{name}', @groupId);";
                    SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@groupId", groupId);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        public string GetInfo()
        {
            string result = groupName + ": ";
            using (SqlConnection sqlConnection = GetConnection())
            {
                try
                {
                    string sql = $"SELECT Member.MemberName, Member.MemberId from Member where Member.GroupId = @groupId;";
                    SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@groupId", groupId);
                    sqlConnection.Open();
                    SqlDataReader resultSql = sqlCommand.ExecuteReader();
                    while (resultSql.Read())
                    {
                        result += $"{resultSql["MemberName"]} id({resultSql["MemberId"]}), ";
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            if (result == groupName + ": ")
            {
                return $"{groupName}: no members";
            }
            return result;

        }

        private SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection("server=DESKTOP-48OR6S4\\SQLEXPRESS; database=ProjectGroup; uid=group; password=1234; TrustServerCertificate=True;");
            return connection;
        }
    }
}