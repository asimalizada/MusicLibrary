using Core.DependencyResolvers.Ninject;
using Core.Extensions;
using MusicLibrary.Business.Abstract;
using MusicLibrary.Business.DependencyResolvers.Ninject;
using MusicLibrary.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace MusicLibrary.FormUI.CRUDForms
{
    public partial class MusicForm : Form
    {
        private readonly IGenreService _genreService;
        private readonly IMusicService _musicService;

        public MusicForm()
        {
            InitializeComponent();
            this._genreService = InstanceFactory
                .GetInstance<IGenreService>(new BusinessModule());
            this._musicService = InstanceFactory
                .GetInstance<IMusicService>(new BusinessModule());
        }

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            this._musicService.Add(new Music
            {
                Name = this.tbxNameMusic.Text,
                GenreId = (int)this.cmbGenresMusic.SelectedValue
            });

            this.LoadMusics();
        }

        private void btnUpdateMusic_Click(object sender, EventArgs e)
        {
            this._musicService.Update(new Music
            {
                Id = (int)this.dgwMusics.CurrentRow?.Cells["Id"].Value,
                Name = this.tbxNameMusic.Text,
                GenreId = (int)this.cmbGenresMusic.SelectedValue
            });
            this.LoadMusics();
        }

        private void btnDeleteMusic_Click(object sender, EventArgs e)
        {
            this._musicService.Delete(new Music
            {
                Id = (int)this.dgwMusics.CurrentRow?.Cells["Id"].Value
            });
            this.LoadMusics();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            this._genreService.Add(new Genre
            {
                Name = this.tbxNameGenre.Text
            });
            this.LoadGenresToCmb();
            this.LoadGenres();
        }

        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            this._genreService.Update(new Genre
            {
                Id = (int)this.dgwGenres.CurrentRow?.Cells["Id"].Value,
                Name = this.tbxNameGenre.Text
            });
            this.LoadGenresToCmb();
            this.LoadGenres();
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            this._genreService.Delete(new Genre
            {
                Id = (int)this.dgwGenres.CurrentRow?.Cells["Id"].Value
            });
            this.LoadGenresToCmb();
            this.LoadGenres();
        }

        private void dgwGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tbxNameGenre.Text = 
                this.dgwGenres.CurrentRow?.Cells["Name"].Value.ToString();
        }

        private void dgwMusics_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tbxNameMusic.Text =
                this.dgwMusics.CurrentRow?.Cells["Name"].Value.ToString();
            this.cmbGenresMusic.SelectedValue =
                this.dgwMusics.CurrentRow?.Cells["GenreId"].Value;
        }

        private void MusicForm_Load(object sender, EventArgs e)
        {
            this.LoadGenres();
            this.LoadMusics();
            this.LoadGenresToCmb();

            this.cmbMusicGenreId.DataSource = this._genreService.GetAll();
            this.cmbMusicGenreId.DisplayMember = "Name";
            this.cmbMusicGenreId.ValueMember = "Id";
        }

        private void LoadGenres()
        {
            this.dgwGenres.DataSource = this._genreService.GetAll();
        }

        private void LoadMusics()
        {
            this.dgwMusics.DataSource = this._musicService.GetAll();
        }

        private void LoadGenresToCmb()
        {
            this.cmbGenresMusic.DataSource = this._genreService.GetAll();
            this.cmbGenresMusic.DisplayMember = "Name";
            this.cmbGenresMusic.ValueMember = "Id";
        }

        private void btnMusicSearch_Click(object sender, EventArgs e)
        {
            string name = this.tbxMusicNameSearch.Text;
            int genreId = this.cmbMusicGenreId.SelectedValue.ToInt();
            int strParam = this.cmbSearchParameters.SelectedIndex;
            // 0=>c 1=>s 2=>e 

            this.dgwMusics.DataSource =
                this._musicService.Search(name, genreId, strParam);
        }

        private void btnSearchGenre_Click(object sender, EventArgs e)
        {

        }
    }
}
