using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishTracker
{
    public partial class FishTrackerList : Form
    {
        public FishTrackerList()
        {
            InitializeComponent();
        }

        private void radioButtonLength_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataGridView("CatchLength", checkBoxDescending.Checked);
        }

        private void radioButtonWeight_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataGridView("CatchWeight", checkBoxDescending.Checked);
        }

        private void radioButtonTackle_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataGridView("CatchTackle", checkBoxDescending.Checked);
        }

        private void radioButtonLocation_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataGridView("CatchLocation", checkBoxDescending.Checked);
        }

        private void radioButtonSpecies_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataGridView("CatchSpecies", checkBoxDescending.Checked);
        }

        private void radioButtonDate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataGridView("CatchDate", checkBoxDescending.Checked);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataGridView("CatchPhoto", radioButtonPhoto.Checked);
        }

        private void checkBoxDescending_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonDate.Checked)
            {
                UpdateDataGridView("CatchDate", checkBoxDescending.Checked);
            } 
            else if(radioButtonSpecies.Checked)
            {
                UpdateDataGridView("CatchSpecies", checkBoxDescending.Checked);

            }
            else if(radioButtonPhoto.Checked)
            {
                UpdateDataGridView("CatchPhoto", checkBoxDescending.Checked);

            }
            else if(radioButtonLocation.Checked)
            {
                UpdateDataGridView("CatchLocation", checkBoxDescending.Checked);

            }
            else if(radioButtonTackle.Checked)
            {
                UpdateDataGridView("CatchTackle", checkBoxDescending.Checked);

            }
            else if(radioButtonWeight.Checked)
            {
                UpdateDataGridView("CatchWeight", checkBoxDescending.Checked);

            }
            else if(radioButtonLength.Checked)
            {
                UpdateDataGridView("CatchLength", checkBoxDescending.Checked);

            }
        }

        private void FishTrackerList_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }


        private void UpdateDataGridView(string sortOption = "CatchDate", bool descending = true)
        {
            using (FishTrackerContext database = new())
            {
                switch (sortOption)
                {
                    case "CatchPhoto":

                            var catchDataPhoto = (
                               from @catch in database.Catches
                               orderby @catch.CatchPhoto descending, @catch.CatchDate descending
                               select new 
                               {
                                   @catch.CatchSpecies,
                                   @catch.CatchDate,
                                   @catch.CatchPhoto,
                                   @catch.CatchLocation,
                                   @catch.CatchTackle,
                                   @catch.CatchWeight,
                                   @catch.CatchLength,
                                   @catch.CatchNotes,
                                   @catch.CatchId
                               }
                           )
                           .ToList();

                            dataGridViewCatches.DataSource = catchDataPhoto;
                            dataGridViewCatches.Refresh();
                        
                        break;

                    case "CatchDate":
                        if (descending)
                        {
                            var catchData = (
                                from @catch in database.Catches
                                orderby @catch.CatchDate descending
                                select new
                                {
                                    @catch.CatchSpecies,
                                    @catch.CatchDate,
                                    @catch.CatchPhoto,
                                    @catch.CatchLocation,
                                    @catch.CatchTackle,
                                    @catch.CatchWeight,
                                    @catch.CatchLength,
                                    @catch.CatchNotes,
                                    @catch.CatchId
                                }
                            )
                            .ToList();

                            dataGridViewCatches.DataSource = catchData;
                            dataGridViewCatches.Refresh();
                        }
                        else
                        {
                            var catchData = (
                                from @catch in database.Catches
                                orderby @catch.CatchDate
                                select new
                                {
                                    @catch.CatchSpecies,
                                    @catch.CatchDate,
                                    @catch.CatchPhoto,
                                    @catch.CatchLocation,
                                    @catch.CatchTackle,
                                    @catch.CatchWeight,
                                    @catch.CatchLength,
                                    @catch.CatchNotes,
                                    @catch.CatchId
                                }
                            )
                            .ToList();

                            dataGridViewCatches.DataSource = catchData;
                            dataGridViewCatches.Refresh();
                        }
                        break;

                    case "CatchSpecies":
                        if (descending)
                        {
                            var catchData = (
                                from @catch in database.Catches
                                orderby @catch.CatchSpecies descending, @catch.CatchDate descending
                                select new
                                {
                                    @catch.CatchSpecies,
                                    @catch.CatchDate,
                                    @catch.CatchPhoto,
                                    @catch.CatchLocation,
                                    @catch.CatchTackle,
                                    @catch.CatchWeight,
                                    @catch.CatchLength,
                                    @catch.CatchNotes,
                                    @catch.CatchId
                                }
                            )
                            .ToList();

                            dataGridViewCatches.DataSource = catchData;
                            dataGridViewCatches.Refresh();
                        }
                        else
                        {
                            var catchData = (
                                from @catch in database.Catches
                                orderby @catch.CatchSpecies, @catch.CatchDate descending
                                select new
                                {
                                    @catch.CatchSpecies,
                                    @catch.CatchDate,
                                    @catch.CatchPhoto,
                                    @catch.CatchLocation,
                                    @catch.CatchTackle,
                                    @catch.CatchWeight,
                                    @catch.CatchLength,
                                    @catch.CatchNotes,
                                    @catch.CatchId
                                }
                            )
                            .ToList();

                            dataGridViewCatches.DataSource = catchData;
                            dataGridViewCatches.Refresh();
                        }
                        break;

                    case "CatchLocation":
                        if (descending)
                        {
                            var catchData = (
                                from @catch in database.Catches
                                orderby @catch.CatchLocation descending, @catch.CatchDate descending
                                select new
                                {
                                    @catch.CatchSpecies,
                                    @catch.CatchDate,
                                    @catch.CatchPhoto,
                                    @catch.CatchLocation,
                                    @catch.CatchTackle,
                                    @catch.CatchWeight,
                                    @catch.CatchLength,
                                    @catch.CatchNotes,
                                    @catch.CatchId
                                }
                            )
                            .ToList();

                            dataGridViewCatches.DataSource = catchData;
                            dataGridViewCatches.Refresh();
                        }
                        else
                        {
                            var catchData = (
                                from @catch in database.Catches
                                orderby @catch.CatchLocation, @catch.CatchDate descending
                                select new
                                {
                                    @catch.CatchSpecies,
                                    @catch.CatchDate,
                                    @catch.CatchPhoto,
                                    @catch.CatchLocation,
                                    @catch.CatchTackle,
                                    @catch.CatchWeight,
                                    @catch.CatchLength,
                                    @catch.CatchNotes,
                                    @catch.CatchId
                                }
                            )
                            .ToList();

                            dataGridViewCatches.DataSource = catchData;
                            dataGridViewCatches.Refresh();
                        }
                        break;

                    case "CatchTackle":
                        if (descending)
                        {
                            var catchData = (
                                from @catch in database.Catches
                                orderby @catch.CatchTackle descending, @catch.CatchDate descending
                                select new
                                {
                                    @catch.CatchSpecies,
                                    @catch.CatchDate,
                                    @catch.CatchPhoto,
                                    @catch.CatchLocation,
                                    @catch.CatchTackle,
                                    @catch.CatchWeight,
                                    @catch.CatchLength,
                                    @catch.CatchNotes,
                                    @catch.CatchId
                                }
                            )
                            .ToList();

                            dataGridViewCatches.DataSource = catchData;
                            dataGridViewCatches.Refresh();
                        }
                        else
                        {
                            var catchData = (
                                from @catch in database.Catches
                                orderby @catch.CatchTackle, @catch.CatchDate descending
                                select new
                                {
                                    @catch.CatchSpecies,
                                    @catch.CatchDate,
                                    @catch.CatchPhoto,
                                    @catch.CatchLocation,
                                    @catch.CatchTackle,
                                    @catch.CatchWeight,
                                    @catch.CatchLength,
                                    @catch.CatchNotes,
                                    @catch.CatchId
                                }
                            )
                            .ToList();

                            dataGridViewCatches.DataSource = catchData;
                            dataGridViewCatches.Refresh();
                        }
                        break;
                    case "CatchWeight":
                        if (descending)
                        {
                            var catchData = (
                                from @catch in database.Catches
                                orderby @catch.CatchWeight descending, @catch.CatchDate descending
                                select new
                                {
                                    @catch.CatchSpecies,
                                    @catch.CatchDate,
                                    @catch.CatchPhoto,
                                    @catch.CatchLocation,
                                    @catch.CatchTackle,
                                    @catch.CatchWeight,
                                    @catch.CatchLength,
                                    @catch.CatchNotes,
                                    @catch.CatchId
                                }
                            )
                            .ToList();

                            dataGridViewCatches.DataSource = catchData;
                            dataGridViewCatches.Refresh();
                        }
                        else
                        {
                            var catchData = (
                                from @catch in database.Catches
                                orderby @catch.CatchWeight, @catch.CatchDate descending
                                select new
                                {
                                    @catch.CatchSpecies,
                                    @catch.CatchDate,
                                    @catch.CatchPhoto,
                                    @catch.CatchLocation,
                                    @catch.CatchTackle,
                                    @catch.CatchWeight,
                                    @catch.CatchLength,
                                    @catch.CatchNotes,
                                    @catch.CatchId
                                }
                            )
                            .ToList();

                            dataGridViewCatches.DataSource = catchData;
                            dataGridViewCatches.Refresh();
                        }
                        break;
                    case "CatchLength":
                        if (descending)
                        {
                            var catchData = (
                                from @catch in database.Catches
                                orderby @catch.CatchLength descending, @catch.CatchDate descending
                                select new
                                {
                                    @catch.CatchSpecies,
                                    @catch.CatchDate,
                                    @catch.CatchPhoto,
                                    @catch.CatchLocation,
                                    @catch.CatchTackle,
                                    @catch.CatchWeight,
                                    @catch.CatchLength,
                                    @catch.CatchNotes,
                                    @catch.CatchId
                                }
                            )
                            .ToList();

                            dataGridViewCatches.DataSource = catchData;
                            dataGridViewCatches.Refresh();
                        }
                        else
                        {
                            var catchData = (
                                from @catch in database.Catches
                                orderby @catch.CatchLength, @catch.CatchDate descending
                                select new
                                {
                                    @catch.CatchSpecies,
                                    @catch.CatchDate,
                                    @catch.CatchPhoto,
                                    @catch.CatchLocation,
                                    @catch.CatchTackle,
                                    @catch.CatchWeight,
                                    @catch.CatchLength,
                                    @catch.CatchNotes,
                                    @catch.CatchId
                                }
                            )
                            .ToList();

                            dataGridViewCatches.DataSource = catchData;
                            dataGridViewCatches.Refresh();
                        }
                        break;

                    default:
                        break;
                }
            }
        }


    }
}
