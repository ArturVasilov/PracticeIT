using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class MyDinamicForm : Form
    {
        public const int sizex = 600;
        public const int sizey = 300;

        Object Changing_Object = new Object();

        int what_object_changing; //какой объект изменяется

        public MyDinamicForm()
        {
            InitializeComponent();
        }

        private void ChooseCreateObjectCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (ChooseCreateObjectCB.SelectedIndex)
            {
                case 0:
                    XKoord.Visible = true;
                    YKoord.Visible = true;
                    XSize.Visible = true;
                    YSize.Visible = true;
                    TextEditOrProgBarValue.Visible = true;
                    EnterElementsL.Visible = false;
                    EnterItemsLV.Visible = false;
                    XKoord.Text = "Коорд. Х";
                    YKoord.Text = "Коорд. У";
                    XSize.Text = "Размер Х";
                    YSize.Text = "Размер У";
                    TextEditOrProgBarValue.Text = "Текст";
                    break;

                case 1:
                    XKoord.Visible = true;
                    YKoord.Visible = true;
                    XSize.Visible = true;
                    YSize.Visible = true;
                    TextEditOrProgBarValue.Visible = true;
                    EnterElementsL.Visible = false;
                    EnterItemsLV.Visible = false;
                    XKoord.Text = "Коорд. Х";
                    YKoord.Text = "Коорд. У";
                    XSize.Text = "Размер Х";
                    YSize.Text = "Размер У";
                    TextEditOrProgBarValue.Text = "Текст";
                    break;

                case 2:
                    XKoord.Visible = true;
                    YKoord.Visible = true;
                    XSize.Visible = true;
                    YSize.Visible = true;
                    EnterElementsL.Visible = true;
                    EnterItemsLV.Visible = true;
                    TextEditOrProgBarValue.Visible = false;
                    XKoord.Text = "Коорд. Х";
                    YKoord.Text = "Коорд. У";
                    XSize.Text = "Размер Х";
                    YSize.Text = "Размер У";
                    break;

                default:
                    XKoord.Visible = true;
                    YKoord.Visible = true;
                    XSize.Visible = false;
                    YSize.Visible = false;
                    EnterElementsL.Visible = false;
                    EnterItemsLV.Visible = false;
                    XKoord.Text = "Коорд. Х";
                    YKoord.Text = "Коорд. У";
                    TextEditOrProgBarValue.Visible = true;
                    TextEditOrProgBarValue.Text = "Значение";
                    break;
            }
            what_object_changing = -1; //не изменяем, а создаем компонент
            ChangingObjectL.Visible = false;
        }

        private void CreateComponents_Click(object sender, EventArgs e)
        {
            if (what_object_changing == -1)
            {
                #region CreateObject
                switch (ChooseCreateObjectCB.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            if ((Convert.ToInt32(XKoord.Text) + Convert.ToInt32(XSize.Text) > sizex) ||
                               (Convert.ToInt32(YKoord.Text) + Convert.ToInt32(YSize.Text) > sizey))
                                MessageBox.Show("Координаты слишком большие!" +
                                "\nКнопка отобразится некорректно." +
                                "\nМаксимальные размеры " + sizex + "x" + sizey + "!");
                            else
                            {
                                Button add_button = new Button();
                                add_button.Left = Convert.ToInt32(XKoord.Text);
                                add_button.Top = Convert.ToInt32(YKoord.Text);
                                add_button.Height = Convert.ToInt32(YSize.Text);
                                add_button.Width = Convert.ToInt32(XSize.Text);
                                add_button.Text = TextEditOrProgBarValue.Text;
                                add_button.MouseClick += add_button_MouseClick;
                                AddPanel.Controls.Add(add_button);
                            }
                        }

                        catch (FormatException fe)
                        {
                            MessageBox.Show(fe.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;

                    case 1:
                        try
                        {
                            if ((Convert.ToInt32(XKoord.Text) + Convert.ToInt32(XSize.Text) > sizex) ||
                                 (Convert.ToInt32(YKoord.Text) + Convert.ToInt32(YSize.Text) > sizey))
                                MessageBox.Show("Координаты слишком большие!" +
                                    "\nНадпись отобразится некорректно." +
                                    "\nМаксимальные размеры " + sizex + "x" + sizey + "!");
                            else
                            {
                                Label add_label = new Label();
                                add_label.Left = Convert.ToInt32(XKoord.Text);
                                add_label.Top = Convert.ToInt32(YKoord.Text);
                                add_label.Height = Convert.ToInt32(YSize.Text);
                                add_label.Width = Convert.ToInt32(XSize.Text);
                                add_label.Text = TextEditOrProgBarValue.Text;
                                add_label.MouseClick += add_label_MouseClick;

                                AddPanel.Controls.Add(add_label);
                            }
                        }

                        catch (FormatException fe)
                        {
                            MessageBox.Show(fe.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;

                    case 2:
                        try
                        {
                            if ((Convert.ToInt32(XKoord.Text) + Convert.ToInt32(XSize.Text) > sizex) ||
                                 (Convert.ToInt32(YKoord.Text) + Convert.ToInt32(YSize.Text) > sizey))
                                MessageBox.Show("Координаты слишком большие!" +
                                    "\nСписок отобразится некорректно." +
                                    "\nМаксимальные размеры " + sizex + "x" + sizey + "!");
                            else
                            {
                                ListView add_listview = new ListView();
                                add_listview.Left = Convert.ToInt32(XKoord.Text);
                                add_listview.Top = Convert.ToInt32(YKoord.Text);
                                add_listview.Height = Convert.ToInt32(YSize.Text);
                                add_listview.Width = Convert.ToInt32(XSize.Text);
                                add_listview.MouseClick += add_listviewMouseClick;

                                string[] items_tokens = EnterItemsLV.Lines;
                                for (int i = 0; i < items_tokens.Length; i++)
                                {
                                    add_listview.Items.Add(items_tokens[i]);
                                }
                                AddPanel.Controls.Add(add_listview);
                            }
                        }

                        catch (FormatException fe)
                        {
                            MessageBox.Show(fe.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;

                    default:
                        try
                        {
                            if (((Convert.ToInt32(TextEditOrProgBarValue.Text) > 100) ||
                                (Convert.ToInt32(TextEditOrProgBarValue.Text) < 0)))
                                MessageBox.Show("Строка состояния принимает значения от 0 до 100!");
                            else if
                                ((Convert.ToInt32(XKoord.Text) > sizex - 50) ||
                                (Convert.ToInt32(YKoord.Text) > sizey - 30))
                                MessageBox.Show("Координаты слишком большие!" +
                                    "\nСтрока состояния отобразится некорректно." +
                                    "\nМаксимальные размеры " + sizex + "x" + sizey + "!");
                            else
                            {
                                ProgressBar add_progressbar = new ProgressBar();
                                add_progressbar.Left = Convert.ToInt32(XKoord.Text);
                                add_progressbar.Top = Convert.ToInt32(YKoord.Text);
                                add_progressbar.Value = Convert.ToInt32(TextEditOrProgBarValue.Text);
                                add_progressbar.MouseClick += add_progressbar_MouseClick;
                                AddPanel.Controls.Add(add_progressbar);
                            }
                        }
                        catch (FormatException fe)
                        {
                            MessageBox.Show(fe.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                }
                #endregion
            }
            else
            {
                #region ChangeObject
                switch (what_object_changing)
                {
                case 0:
                        try
                        {
                            if ((Convert.ToInt32(XKoord.Text) + Convert.ToInt32(XSize.Text) > sizex) ||
                                (Convert.ToInt32(YKoord.Text) + Convert.ToInt32(YSize.Text) > sizey))
                                MessageBox.Show("Координаты слишком большие!" +
                                    "\nКнопка отобразится некорректно." +
                                    "\nМаксимальные размеры " + sizex + "x" + sizey + "!");
                            else
                            {
                                ((Button)Changing_Object).Left = Convert.ToInt32(XKoord.Text);
                                ((Button)Changing_Object).Top = Convert.ToInt32(YKoord.Text);
                                ((Button)Changing_Object).Height = Convert.ToInt32(YSize.Text);
                                ((Button)Changing_Object).Width = Convert.ToInt32(XSize.Text);
                                ((Button)Changing_Object).Text = TextEditOrProgBarValue.Text;
                            }
                        }

                        catch (FormatException fe)
                        {
                            MessageBox.Show(fe.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    break;

                case 1:
                    try
                    {
                        if ((Convert.ToInt32(XKoord.Text) + Convert.ToInt32(XSize.Text) > sizex) ||
                            (Convert.ToInt32(YKoord.Text) + Convert.ToInt32(YSize.Text) > sizey))
                            MessageBox.Show("Координаты слишком большие!" +
                                "\nНадпись отобразится некорректно." +
                                "\nМаксимальные размеры " + sizex + "x" + sizey + "!");
                        else
                        {
                            ((Label)Changing_Object).Left = Convert.ToInt32(XKoord.Text);
                            ((Label)Changing_Object).Top = Convert.ToInt32(YKoord.Text);
                            ((Label)Changing_Object).Height = Convert.ToInt32(YSize.Text);
                            ((Label)Changing_Object).Width = Convert.ToInt32(XSize.Text);
                            ((Label)Changing_Object).Text = TextEditOrProgBarValue.Text;
                        }
                    }

                    catch (FormatException fe)
                    {
                        MessageBox.Show(fe.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case 2:
                    try
                    {
                        if ((Convert.ToInt32(XKoord.Text) + Convert.ToInt32(XSize.Text) > sizex) ||
                            (Convert.ToInt32(YKoord.Text) + Convert.ToInt32(YSize.Text) > sizey))
                            MessageBox.Show("Координаты слишком большие!" +
                                "\nСписок отобразится некорректно." +
                                "\nМаксимальные размеры " + sizex + "x" + sizey + "!");
                        else
                        {
                            ((ListView)Changing_Object).Left = Convert.ToInt32(XKoord.Text);
                            ((ListView)Changing_Object).Top = Convert.ToInt32(YKoord.Text);
                            ((ListView)Changing_Object).Height = Convert.ToInt32(YSize.Text);
                            ((ListView)Changing_Object).Width = Convert.ToInt32(XSize.Text);
                            ((ListView)Changing_Object).Items.Clear();

                            string[] items_tokens = EnterItemsLV.Lines;
                            for (int i = 0; i < items_tokens.Length; i++)
                            {
                                ((ListView)Changing_Object).Items.Add(items_tokens[i]);
                            }
                        }
                    }

                    catch (FormatException fe)
                    {
                        MessageBox.Show(fe.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                default:
                    try
                    {
                        if (((Convert.ToInt32(TextEditOrProgBarValue.Text) > 100) ||
                            (Convert.ToInt32(TextEditOrProgBarValue.Text) < 0)))
                            MessageBox.Show("Строка состояния принимает значения от 0 до 100!");
                        else if ((Convert.ToInt32(XKoord.Text) > sizex - 50) ||
                             (Convert.ToInt32(YKoord.Text) > sizey - 30)) //длиина и высота строки состояния
                            MessageBox.Show("Координаты слишком большие!" +
                                "\nСтрока состояния отобразится некорректно." +
                                "\nМаксимальные размеры " + sizex + "x" + sizey + "!");
                        else
                        {
                            ((ProgressBar)Changing_Object).Left = Convert.ToInt32(XKoord.Text);
                            ((ProgressBar)Changing_Object).Top = Convert.ToInt32(YKoord.Text);
                            ((ProgressBar)Changing_Object).Value = Convert.ToInt32(TextEditOrProgBarValue.Text);
                        }
                    }

                    catch (FormatException fe)
                    {
                        MessageBox.Show(fe.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
                #endregion
            }
        }

        private void add_button_MouseClick(object sender, MouseEventArgs e)
        {
            ChangingObjectL.Text = "Кнопка.";
            ChangingObjectL.Visible = true;
            XKoord.Visible = true;
            YKoord.Visible = true;
            XSize.Visible = true;
            YSize.Visible = true;
            TextEditOrProgBarValue.Visible = true;
            EnterElementsL.Visible = false;
            EnterItemsLV.Visible = false;

            Changing_Object = (Button)sender;
            XKoord.Text = ((Button)Changing_Object).Left.ToString();
            YKoord.Text = ((Button)Changing_Object).Top.ToString();
            XSize.Text = ((Button)Changing_Object).Width.ToString();
            YSize.Text = ((Button)Changing_Object).Height.ToString();
            TextEditOrProgBarValue.Text = ((Button)Changing_Object).Text;
            what_object_changing = 0;
        }
        private void add_label_MouseClick(object sender, MouseEventArgs e)
        {
            ChangingObjectL.Text = "Надпись.";
            ChangingObjectL.Visible = true;
            XKoord.Visible = true;
            YKoord.Visible = true;
            XSize.Visible = true;
            YSize.Visible = true;
            TextEditOrProgBarValue.Visible = true;
            EnterElementsL.Visible = false;
            EnterItemsLV.Visible = false;

            Changing_Object = (Label)sender;
            XKoord.Text = ((Label)Changing_Object).Left.ToString();
            YKoord.Text = ((Label)Changing_Object).Top.ToString();
            XSize.Text = ((Label)Changing_Object).Width.ToString();
            YSize.Text = ((Label)Changing_Object).Height.ToString();
            TextEditOrProgBarValue.Text = ((Label)Changing_Object).Text;
            what_object_changing = 1;
        }
        private void add_listviewMouseClick(object sender, MouseEventArgs e)
        {
            ChangingObjectL.Text = "Список.";
            ChangingObjectL.Visible = true;
            XKoord.Visible = true;
            YKoord.Visible = true;
            XSize.Visible = true;
            YSize.Visible = true;
            TextEditOrProgBarValue.Visible = false;
            EnterElementsL.Visible = true;
            EnterItemsLV.Visible = true;

            Changing_Object = (ListView)sender;
            XKoord.Text = ((ListView)Changing_Object).Left.ToString();
            YKoord.Text = ((ListView)Changing_Object).Top.ToString();
            XSize.Text = ((ListView)Changing_Object).Width.ToString();
            YSize.Text = ((ListView)Changing_Object).Height.ToString();

            string[] h_string = new string[((ListView)Changing_Object).Items.Count];
            for (int i = 0; i < ((ListView)Changing_Object).Items.Count; i++)
            {
                h_string[i] = ((ListView)Changing_Object).Items[i].ToString();
                //ListViewItem: {Items[i]}
                h_string[i] = h_string[i].Substring(15);
                h_string[i] = h_string[i].Remove(h_string[i].Length - 1);
            }
            EnterItemsLV.Lines = h_string;
            what_object_changing = 2;
        }
        private void add_progressbar_MouseClick(object sender, MouseEventArgs e)
        {
            ChangingObjectL.Text = "Строка состояния.";
            ChangingObjectL.Visible = true;
            XKoord.Visible = true;
            YKoord.Visible = true;
            XSize.Visible = false;
            YSize.Visible = false;
            TextEditOrProgBarValue.Visible = true;
            EnterElementsL.Visible = false;
            EnterItemsLV.Visible = false;

            Changing_Object = (ProgressBar)sender;
            XKoord.Text = ((ProgressBar)Changing_Object).Left.ToString();
            YKoord.Text = ((ProgressBar)Changing_Object).Top.ToString();
            TextEditOrProgBarValue.Text = ((ProgressBar)Changing_Object).Value.ToString();
            what_object_changing = 3;
        }

        private void DeleteComponentB_Click(object sender, EventArgs e)
        {
            if (what_object_changing == -1)
                MessageBox.Show("Вы не выбрали объект для удаления!!");
            else
            {
                AddPanel.Controls.Remove((Control)Changing_Object);
            }
        }
    }
}
