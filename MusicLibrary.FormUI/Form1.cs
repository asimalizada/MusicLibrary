using Core.DependencyResolvers.Ninject;
using MusicLibrary.Business.Abstract;
using MusicLibrary.Business.DependencyResolvers.Ninject;
using System;
using System.Windows.Forms;

namespace MusicLibrary.FormUI
{
    public partial class Form1 : Form
    {
        private readonly IMusicService _musicService;

        public Form1()
        {
            InitializeComponent();
            _musicService = InstanceFactory
                .GetInstance<IMusicService>(new BusinessModule());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this._musicService.GetAll();
        }
    }
}
