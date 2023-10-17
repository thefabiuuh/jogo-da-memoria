using System.Windows.Forms;

namespace JogoDaMemoria
{
    public partial class Form1 : Form
    {



        // Random � usado para escolher �cones aleat�rios para os quadrados
        Random random = new Random();


        // Cada uma dessas letras � um �cone
        // na fonte Webdings,
        // e cada �cone aparece duas vezes nesta lista
        List<string> icons = new List<string>()
            {
            "a", "a", "b", "b", "c", "c", "K", "K",
            "D", "D", "v", "v", "w", "w", "z", "z"

            };

        Label firstClicked = null;
        Label secondClicked = null;


        public Form1()

        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void AssignIconsToSquares()
        {

            // O LayoutPanel possui 16 r�tulos,
            // e a lista de �cones possui 16 �cones,
            // ent�o um �cone � retirado aleatoriamente da lista
            // e adicionado a cada r�tulo
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);

                }
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                return;
            }

            // AQUI DENTRO VAI AS A��ES DO CLICK DO MOUSE
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;


                CheckForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();

            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }

            }
            MessageBox.Show("Voc� acertou todos os icones.", "Parab�ns");
            Close();
        }

    }
}

