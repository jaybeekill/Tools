using System.ComponentModel;
using System.Windows.Forms;

namespace CsvChecker
{
    public partial class Form1 : Form
    {
        DtoResults? Invalids { get; set; }

        List<string> Valids { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";

            // Display the openFile dialog.
            DialogResult result = openFileDialog1.ShowDialog();

            // OK button was pressed.
            if (result == DialogResult.OK)
            {
                this.textBoxFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void buttonCheckCsv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxFilePath.Text))
            {
                MessageBox.Show("Veuillez sélectionner le fichier.");
                return;
            }

            if (numericNbColumn.Value == 0)
            {
                MessageBox.Show("Veuillez sélectionner le nombre de colonnes attendu.");
                return;
            }

            this.Invalids = new DtoResults();
            this.Valids = new List<string>();

            var csvContent = File.ReadAllText(this.textBoxFilePath.Text);
            var lines = csvContent.Split(Environment.NewLine, StringSplitOptions.None);
            foreach (var line in lines)
            {
                var columns = line.Split(";");

                // > Check if file has uniform column number
                if (columns.Count() != numericNbColumn.Value)
                {
                    Invalids.Add(new DtoResult()
                    {
                        NbColumn = columns.Count()
                        ,
                        Content = line
                    });
                }
                else
                {
                    List<string> invalidCols = columns.Where(x => x.Contains('"') && !x.StartsWith('"')).ToList();
                    if (invalidCols.Count > 0)
                    {
                        Invalids.Add(new DtoResult()
                        {
                            NbColumn = columns.Count()
                            ,
                            Content = line
                        });
                    } else
                    {
                        Valids.Add(line);
                    }
                    
                }

            }
            //var source = new BindingList<DtoResults>(invalids);
            dataGridView1.DataSource = Invalids; //new BindingSource(invalids);

        }

        private void buttonAutodetectColumnNumber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxFilePath.Text))
            {
                MessageBox.Show("Veuillez sélectionner le fichier.");
                return;
            }
            var csvContent = File.ReadAllText(this.textBoxFilePath.Text);
            var lines = csvContent.Split(Environment.NewLine, StringSplitOptions.None);
            var line = lines[0];
            var columns = line.Split(";");
            this.numericNbColumn.Value = columns.Count();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";

            // Display the openFile dialog.
            DialogResult result = saveFileDialog1.ShowDialog();

            // OK button was pressed.
            if (result == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, Invalids.Select(x => x.Content));
            }

        }

        private void buttonExportClean_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";

            // Display the openFile dialog.
            DialogResult result = saveFileDialog1.ShowDialog();

            // OK button was pressed.
            if (result == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, Valids);
            }
        }
    }
}