using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMusic
{
    public partial class fPlay : Form
    {
        // Song object
        public class Song
        {
            private string id;
            private string title;
            private string artist;
            private string duration;
            private string path;
            public string getId()
            {
                return id;
            }
            public string getTitle()
            {
                return title;
            }
            public string getArtist()
            {
                return artist;
            }
            public string getDuration()
            {
                return duration;
            }
            public string getPath()
            {
                return path;
            }
            public Song(string id, string title, string artist, string duration, string path)
            {
                this.id = id;
                this.title = title;
                this.artist = artist;
                this.duration = duration;
                this.path = path;
            }
        }
        //Node object
        public class Node
        {
            public Song element;
            public Node next, prev;
            public Node()
            {
                element = null;
                next = prev = null;
            }
            public Node(Song element)
            {
                this.element = element;
                next = prev = null;
            }
        }
        // DoubleLinkedList
        public class DoubleLinkedList
        {
            public Node header;
            public DoubleLinkedList()
            {
                header = new Node(new Song("Header", "End", "Header", "Header", "Header"));
            }
            // Find song by id (Tìm kiếm Node dựa vào id và trả về Node đó)
            public Node Find(string id)
            {
                Node current = new Node();
                current = header;
                while (current.element.getId() != id)
                {
                    current = current.next;
                }
                return current;
            }
            // Find name of a song by name
            public Node FindSong(string name)
            {
                Node current = new Node();
                current = header;
                while (current.element.getTitle() != name)
                {
                    current = current.next;
                }
                return current;
            }
            // Insert Song
            public void InsertAfter(Song newsong, string id)
            {
                Node current = new Node();
                Node newnode = new Node(newsong);
                current = Find(id);
                newnode.next = current.next;
                newnode.prev = current;
                current.next = newnode;
            }
            // Random song
            public Node RandomSong()
            {
                Node current = header;
                Random rd_song = new Random();
                int a = rd_song.Next(1, 10);
                while (current.element.getId() != a.ToString())
                {
                    current = current.next;
                }
                return current;
            }
        }
        // Playlist
        static DoubleLinkedList PlayList()
        {

            DoubleLinkedList dlist = new DoubleLinkedList();

            dlist.InsertAfter(new Song("1", "Acceptance", "Justin Bieber", "3.02", @"\Music\Acceptance-Evgenia_Kostitsyna.mp3"), "Header");

            dlist.InsertAfter(new Song("2", "Arabesque", "Kelly Clarkson", "3.49", @"\Music\Arabesque-Abydos_Musique.mp3"), "1");

            dlist.InsertAfter(new Song("3", "Aurbanni", "Ariana Grande", "3.24", @"\Music\Clair_De_Lune-Aurbanni.mp3"), "2");

            dlist.InsertAfter(new Song("4", "Graceful", "Mariah Carey", "4.01", @"\Music\Graceful-Yigit_Atilla.mp3"), "3");

            dlist.InsertAfter(new Song("5", "Humoresques", "Brenda Lee", "2.06", @"\Music\Dvorak-Humoresques.mp3"), "4");

            dlist.InsertAfter(new Song("6", "My Life", "Naeleck, Sarah Rebecca", "3.06", @"\Music\My_Life-Train.mp3"), "5");

            dlist.InsertAfter(new Song("7", "Impromptus", "Liam Payne", "3.01", @"\Music\Schubert-Impromptus.mp3"), "6");

            dlist.InsertAfter(new Song("8", "Snowing", "Dean Martin", "1.57", @"\Music\Snowing-Peter_Rudenko.mp3"), "7");

            dlist.InsertAfter(new Song("9", "Sonata", "Paul McCartney", "3.47", @"\Music\Sonata-Allegro_moderato.mp3"), "8");

            dlist.InsertAfter(new Song("10", "Kisses", "Sam Smith", "2.50", @"\Music\Zachary_Friederich-Mistletoe_Kisses.mp3"), "9");

            dlist.InsertAfter(new Song("End", "End", "End", "End", "End"), "10");

            return dlist;
        }

        // Khởi tạo playlist sử dụng cho toàn bộ chương trình
        DoubleLinkedList playlist = PlayList();
        Node currentSong;
        Node nextSong;
        Node prevSong;
        // Khởi tạo trình phát nhạc
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        int playing = 0;

        public fPlay()
        {
            InitializeComponent();
            // Các thiết lập khi khởi động chương trình
            currentSong = playlist.Find("1");
            nextSong = currentSong.next;
            prevSong = currentSong.prev;
            SetLabelPic();
            wplayer.controls.stop();
            cbSearch.Text = "Id";
            lbVolume.Text = wplayer.settings.volume.ToString();
            this.Icon = Resource.btnPlaySong1;
        }

        // Event Button Play Song
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (playing == 0)
            {
                PlayMusic();
            }
            else if (playing == 1)
            {
                PauseMusic();
            }
        }

        // Event Button Next Song
        private void btnNext_Click(object sender, EventArgs e)
        {
            string id = currentSong.next.element.getId();
            if (id == "End")
            {
                MessageBox.Show("Không còn bài hát nào cả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                prevSong = currentSong;
                currentSong = currentSong.next;
                nextSong = currentSong.next;
                SetLabelPic();
                StopMusic();
            }
        }

        // Event Button Prev Song
        private void btnPre_Click(object sender, EventArgs e)
        {
            string temp = currentSong.prev.element.getTitle();
            if (temp != "End")
            {
                nextSong = currentSong;
                currentSong = currentSong.prev;
                prevSong = currentSong.prev;
                SetLabelPic();
                StopMusic();
            }
            else
            {
                MessageBox.Show("Không còn bài hát nào cả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Event Button Back
        private void btnBack_Click(object sender, EventArgs e)
        {
            StopMusic();
            this.Close();
        }

        // Event Button Random Song
        private void btnRandom_Click(object sender, EventArgs e)
        {
            currentSong = playlist.RandomSong();
            prevSong = currentSong.prev;
            nextSong = currentSong.next;
            SetLabelPic();
            StopMusic();
        }

        // Set title and path
        private void SetLabelPic()
        {
            lbSongNow.Text = currentSong.element.getTitle();
            lbSongNext.Text = nextSong.element.getTitle();
            lbSongPre.Text = prevSong.element.getTitle();
            wplayer.URL = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + currentSong.element.getPath();
        }

        // Function play, pause, stop
        private void PlayMusic()
        {
            wplayer.controls.play();
            playing = 1;
            btnPlay.BackgroundImage = Resource.btnPauseSong;
        }
        private void PauseMusic()
        {
            wplayer.controls.pause();
            playing = 0;
            btnPlay.BackgroundImage = Resource.btnPlaySong;
        }
        private void StopMusic()
        {
            wplayer.controls.stop();
            playing = 0;
            btnPlay.BackgroundImage = Resource.btnPlaySong;
        }

        // Button volume up and down
        private void btnUp_Click(object sender, EventArgs e)
        {
            wplayer.settings.volume = (wplayer.settings.volume + 10);
            lbVolume.Text = wplayer.settings.volume.ToString();
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            wplayer.settings.volume = (wplayer.settings.volume - 10);
            lbVolume.Text = wplayer.settings.volume.ToString();
        }

        // Event Button Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Node song;
            try
            {
                if (cbSearch.Text == "Id")
                {
                    song = playlist.Find(tbSearch.Text);
                }
                else
                {
                    song = playlist.FindSong(tbSearch.Text);
                }
                if (song.element.getId() != "Header" && song.element.getId() != "End")
                {
                    currentSong = song;
                    nextSong = currentSong.next;
                    prevSong = currentSong.prev;
                    SetLabelPic();
                    StopMusic();
                }
            }
            catch
            {
                MessageBox.Show("Không tìm thấy bài hát.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
