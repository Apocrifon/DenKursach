using Microsoft.VisualBasic.Logging;

namespace Kursach
{
    public partial class Form1 : Form
    {
        BinaryHeap<CRect> heap = new BinaryHeap<CRect>(false);
        public Form1()
        {
            InitializeComponent();
            label3.Text = "";
        }

        private CRect CreateRect()
        {
            var result = new CRect(double.Parse(textBox1.Text), double.Parse(textBox2.Text), comboBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
            label3.Text = string.Format("Длина: {0} Ширина: {1}", CRect.MaxSquare.width, CRect.MaxSquare.height);
            return result;
        }

        private CRect CreateRect(double width, double heigth, string color)
        {
            var result = new CRect(width, heigth, color);
            label3.Text = string.Format("Длина: {0} Ширина: {1}", CRect.MaxSquare.width, CRect.MaxSquare.height);
            return result;
        }

        private bool CheckFields()
        {
            try
            {
                var w = double.Parse(textBox1.Text);
                var h = double.Parse(textBox2.Text);
                var c = comboBox1.Text;

                return (w > 0 && h > 0 && c != "");
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
            {
                MessageBox.Show("Неправильные данные");
                return;
            }

            var temp = CreateRect();
            heap.Insert(temp);

            UpdateTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (heap.Count > 0)
            {
                heap.Delete();
            }
            if (heap.Count == 0)
            {
                CRect.MaxSquare = null;
                label3.Text = "";
            }
            else
                label3.Text = string.Format("Длина: {0} Ширина: {1}", CRect.MaxSquare.width, CRect.MaxSquare.height);

            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < heap.Count; i++)
            {
                var item = heap[i];
                dataGridView1.Rows.Add(i + 1, item.width, item.height, item.color);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            heap = new BinaryHeap<CRect>(heap.IsMax);
            if (heap.Count == 0)
            {
                CRect.MaxSquare = null;
                label3.Text = "";
            }
            else
                label3.Text = string.Format("Длина: {0} Ширина: {1}", CRect.MaxSquare.width, CRect.MaxSquare.height);
            UpdateTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newHeap = new BinaryHeap<CRect>(!heap.IsMax);
            for (int i = 0; i < heap.Count; i++)
            {
                var item = heap[i];
                newHeap.Insert(item);
            }
            heap = newHeap;
            UpdateTable();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var line = "";
            for (int i = 0; i < heap.Count; i++)
            {
                line += heap[i].width.ToString() + " " + heap[i].height.ToString() + " " + heap[i].color.ToString() + "\n";

            }
            File.WriteAllText("../../../INFO.txt", line);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var line = File.ReadAllText("../../../INFO.txt").Split("\n");
            for (int i = 0; i < line.Length - 1; i++)
            {
                var data = line[i].Split(" ");
                var rect = CreateRect(int.Parse(data[0]), int.Parse(data[1]), data[2]);
                heap[i] = rect;
            }

            UpdateTable();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var line = File.ReadAllText("../../../INFO.txt").Split("\n");
            var tempHeap = new BinaryHeap<CRect>(heap.IsMax);
            for (int i = 0; i < line.Length - 1; i++)
            {
                var data = line[i].Split(" ");
                var rect = CreateRect(int.Parse(data[0]), int.Parse(data[1]), data[2]);
                tempHeap[i] = rect;
            }
            heap = heap.Merge(tempHeap);
            UpdateTable();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
            {
                MessageBox.Show("Неправильные данные");
                return;
            }
            heap.Delete();
            var temp = CreateRect();
            heap.Insert(temp);
            UpdateTable();
        }
    }
}