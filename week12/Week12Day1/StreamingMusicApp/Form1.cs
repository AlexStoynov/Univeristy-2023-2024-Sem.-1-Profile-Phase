namespace StreamingMusicApp
{
    public partial class Form1 : Form
    {
        private List<User> users;
        private List<Song> songs;
        Song song;
        public Form1()
        {
            InitializeComponent();
            users = new List<User>();
            songs = new List<Song>();
        }

        private void ShowUsersBtn_Click(object sender, EventArgs e)
        {
            ViewAllUsersLB.Items.Clear();
            foreach (User user in users)
            {
                ViewAllUsersLB.Items.Add(user.ToString());
            }
        }

        private void CreateUserBtn_Click_1(object sender, EventArgs e)
        {
            User user;

            if (UserAddress.Text != null)
            {
                user = new User(UserName.Text, UserEMail.Text, UserAddress.Text);
            }
            else
            {
                user = new User(UserName.Text, UserEMail.Text);
            }
            users.Add(user);
        }

        private void CreateSongBtn_Click(object sender, EventArgs e)
        {
            if (SongGenre.Text == "CLASSIC")
            {
                song = new Song((int)IDSong.Value, SongArtist.Text, SongTitle.Text, (int)SongDuration.Value);
            }
            else if (SongGenre.Text == "DANCE")
            {
                song = new Song((int)IDSong.Value, SongArtist.Text, SongTitle.Text, (int)SongDuration.Value, Genre.DANCE);
            }
            else if (SongGenre.Text == "POP")
            {
                song = new Song((int)IDSong.Value, SongArtist.Text, SongTitle.Text, (int)SongDuration.Value, Genre.POP);
            }
            else if (SongGenre.Text == "ROCK")
            {
                song = new Song((int)IDSong.Value, SongArtist.Text, SongTitle.Text, (int)SongDuration.Value, Genre.ROCK);
            }
            songs.Add(song);
        }

        private void ShowSongsBtn_Click(object sender, EventArgs e)
        {
            ViewAllSongsLB.Items.Clear();
            foreach (Song song in songs)
            {
                ViewAllSongsLB.Items.Add(song.GetInfo());
            }
        }

        private void ShowInfoBtn_Click(object sender, EventArgs e)
        {
            foreach (User user in users)
            {
                UsersManageLb.Items.Add(user.GetUserName());
            }

            foreach (Song song in songs)
            {
                SongsManageLb.Items.Add($"{song.GetTitle()}");
            }
        }

        private void AddSongToUserBtn_Click(object sender, EventArgs e)
        {
            int selectedSong = SongsManageLb.SelectedIndex;
            int selectedUser = UsersManageLb.SelectedIndex;

            if (selectedSong >= 0 && selectedSong < songs.Count)
            {
                Song song = songs[selectedSong];
                User user = users[selectedUser];

                user.AddSongToFavourites(song);

                MessageBox.Show("Song successfully added to favorites.");
            }
            else
            {
                MessageBox.Show("Please select a song to add to the playlist.");
            }
        }

        private void RemoveSongBtn_Click(object sender, EventArgs e)
        {
            int selectedSong = SongsManageLb.SelectedIndex;
            int selectedUser = UsersManageLb.SelectedIndex;

            if (selectedSong >= 0 && selectedSong < songs.Count)
            {
                User user = users[selectedUser];

                user.RemoveSongFromFavourites(songs[selectedSong].GetTitle());

                MessageBox.Show("Song successfully removed from favorites.");
            }
            else
            {
                MessageBox.Show("Please select a song to remove from the playlist.");
            }
        }

        private void ShowUserFavSongsBtn_Click(object sender, EventArgs e)
        {

        }

        private void showUsersDisplayLb_Click(object sender, EventArgs e)
        {
            foreach (User user in users)
            {
                ShowUsersFinalLb.Items.Add(user.GetUserName());
            }
        }

        private void ShowUserFavSongsBtn_Click_1(object sender, EventArgs e)
        {
            int selectedUser = UsersManageLb.SelectedIndex;
            User user = users[selectedUser];
            UserSongsTb.Text = user.GetFavouriteSongs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}