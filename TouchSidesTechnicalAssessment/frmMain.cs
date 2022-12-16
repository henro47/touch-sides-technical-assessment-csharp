using TouchSidesTechnicalAssessment.classes;

namespace TouchSidesTechnicalAssessment
{
    public partial class frmMain : Form
    {
        MostFrequentWord frequentWord = new MostFrequentWord();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            txtMostSevenCharWord.Text = "";
            txtMostFrequentWord.Text = "";
            txtHighestScore.Text = "";
            pnlShowResult.Visible = false;

            ofdLoadFile.InitialDirectory = @"C:/";
            if (ofdLoadFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(ofdLoadFile.FileName);
                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if(line != null)
                    {
                        frequentWord.regex_line_splitter(line);
                    }
                    
                }
                reader.Dispose();
            }
            Dictionary<string, int> most_freq_word = frequentWord.most_frequent_word_counted();
            Dictionary<string, int> most_freq_seven_char = frequentWord.most_frequent_seven_char_word_counted();
            Dictionary<string, int> highest_scoring_word = frequentWord.word_with_highest_score();

            txtMostFrequentWord.Text = most_freq_word.First().Key + " { " + most_freq_word.First().Value + " }";
            txtMostSevenCharWord.Text = most_freq_seven_char.First().Key + " { " + most_freq_seven_char.First().Value + " }";
            txtHighestScore.Text = highest_scoring_word.First().Key + " { " + highest_scoring_word.First().Value + " }";

            pnlShowResult.Visible = true;
        }
    }
}