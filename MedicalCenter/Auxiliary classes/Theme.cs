using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using MedicalCenter.CustomControls;

namespace MedicalCenter
{
    public static class Theme
    {
        public static ThemesTypes CurrentThemeType { get; set; }
        public enum ThemesTypes
        {
            Light,Dark
        }
        enum ThemeColor
        {
            FormBackgound,
            PageBackGround,
            ListViewBackGroud,
            Button,
            ComboboxBackGround,
            Text,
            DateTimePicker,
            ButtonBorderColor,
            StripText,
            StripBackground,
            LinkLabelText,
            TextBoxBackGround
        }
        private static Dictionary<ThemesTypes,Image>_Icons = new Dictionary<ThemesTypes,Image>()
        {
            {ThemesTypes.Dark, Properties.Resources.CalendarDark},
            {ThemesTypes.Light, Properties.Resources.CalendarLight}
        };
        private static Dictionary<ThemesTypes, FlatStyle> flatStyle = new Dictionary<ThemesTypes, FlatStyle>()
        {
            { ThemesTypes.Dark,FlatStyle.Flat },
            {ThemesTypes.Light,FlatStyle.Standard },
        };
        private static Dictionary<ThemesTypes, BorderStyle> borderStyles = new Dictionary<ThemesTypes, BorderStyle>()
        {
            {ThemesTypes.Dark,BorderStyle.None },
            {ThemesTypes.Light,BorderStyle.Fixed3D }
        };
        private static Dictionary<ThemeColor, Color> Light = new Dictionary<ThemeColor, Color>()
        {
                { ThemeColor.FormBackgound,      SystemColors.Control},
                { ThemeColor.PageBackGround,     Color.FromArgb(240,240,240) },
                { ThemeColor.DateTimePicker,     Color.FromArgb(240,240,240) },
                { ThemeColor.ListViewBackGroud,  SystemColors.Window },
                { ThemeColor.TextBoxBackGround,  SystemColors.Window },
                { ThemeColor.ComboboxBackGround, SystemColors.Window },
                { ThemeColor.LinkLabelText,      Color.FromArgb(0, 0, 255)},
                { ThemeColor.StripBackground,    Color.Transparent }, 
                { ThemeColor.Text,               SystemColors.ControlText},
                { ThemeColor.Button,             Color.Transparent },
                { ThemeColor.ButtonBorderColor,  SystemColors.ActiveBorder },
                { ThemeColor.StripText,          SystemColors.ControlText}
        };
        private static Dictionary<ThemeColor, Color> Dark = new Dictionary<ThemeColor, Color>()
        {
                { ThemeColor.FormBackgound,        Color.FromArgb(31,31,31) },
                { ThemeColor.PageBackGround,       Color.FromArgb(31,31,31) },
                { ThemeColor.ListViewBackGroud,    Color.FromArgb(31,31,31) },
                { ThemeColor.TextBoxBackGround,    Color.FromArgb(31,31,31) },
                { ThemeColor.StripBackground,      Color.FromArgb(31,31,31) },
                { ThemeColor.ComboboxBackGround,   Color.FromArgb(31,31,31) },
                { ThemeColor.DateTimePicker,       Color.FromArgb(31,31,31) },
                { ThemeColor.LinkLabelText,        Color.FromArgb(31,31,31) },
                { ThemeColor.Text,                 Color.FromArgb(233,236,243)},
                { ThemeColor.Button,               Color.FromArgb(30,30,30) },
                { ThemeColor.ButtonBorderColor,    Color.FromArgb(113,96,232) },
                { ThemeColor.StripText,            Color.FromArgb(113,96,232)}
        };
        
        public static class Set
        {
            private static Dictionary<ThemeColor, Color> _currentTheme = null;
            private static FlatStyle _flatStyle;
            private static BorderStyle _borderStyle;

            public static void CurrentTheme(ThemesTypes themeType)
            {
                CurrentThemeType = themeType;
                if (themeType == ThemesTypes.Dark)
                {
                    _currentTheme = Dark;
                    _flatStyle = flatStyle[ThemesTypes.Dark];
                    _borderStyle = borderStyles[ThemesTypes.Dark];
                }
                if (themeType == ThemesTypes.Light)
                {
                    _currentTheme = Light;
                    _flatStyle = flatStyle[ThemesTypes.Light];
                    _borderStyle = borderStyles[ThemesTypes.Light];
                }
            }

            private static void TextBox(params TextBox[]textBoxes)
            {
                foreach(TextBox textBox in textBoxes)
                {
                    textBox.BackColor = _currentTheme[ThemeColor.TextBoxBackGround];
                    textBox.ForeColor = _currentTheme[ThemeColor.Text];
                }
            }
            private static void LinkLabelTheme(params LinkLabel[]linkLabels)
            {
                foreach (LinkLabel linkLabel in linkLabels)
                    linkLabel.LinkColor = _currentTheme[ThemeColor.StripText];
            }
            private static void PagesTheme(TabControl pagesControl)
            {
                foreach (TabPage page in pagesControl.TabPages)
                {
                    page.BackColor = _currentTheme[ThemeColor.ListViewBackGroud];
                    page.ForeColor = _currentTheme[ThemeColor.Text];
                    page.Margin = new Padding(0, 0, 0, 0);
                   
                    for(int i = 0; i < page.Controls.Count; i++)
                        ControlsTheme(page.Controls[i]);
                }
            }
            private static void PanelTheme(Panel panel)
            {
                if(CurrentThemeType == ThemesTypes.Dark)
                    panel.BorderStyle = BorderStyle.Fixed3D;
                for(int i = 0;i < panel.Controls.Count; i++)
                    ControlsTheme(panel.Controls[i]);
            }
            private static void ButtonTheme(params Button[] buttons)
            {
                foreach (Button button in buttons)
                {
                    button.BackColor = _currentTheme[ThemeColor.Button];
                    button.FlatStyle = _flatStyle;
                    button.FlatAppearance.BorderSize = 1;
                    button.FlatAppearance.BorderColor = _currentTheme[ThemeColor.ButtonBorderColor];
                }
            }
            private static void DateTimePickerTheme(params CustomDateTimePicker[] pickers)
            {
                foreach (CustomDateTimePicker picker in pickers)
                {
                    picker.BorderSize = 2;
                    picker.CalendarIcon = _Icons[CurrentThemeType];
                    picker.BorderColor = _currentTheme[ThemeColor.ButtonBorderColor];
                    picker.SkinColor = _currentTheme[ThemeColor.DateTimePicker];
                    picker.TextColor = _currentTheme[ThemeColor.Text];
                }
            }
            private static void CheckControl(Control control)
            {
                Button b = control as Button;
                if (b != null) ButtonTheme(b);

                CustomDateTimePicker dt = control as CustomDateTimePicker;
                if (dt != null) DateTimePickerTheme(dt);

                TabControl c = control as TabControl;
                if (c != null) PagesTheme(c);

                GroupBox grp = control as GroupBox;
                if (grp != null) GroupBoxTheme(grp);

                StatusStrip strip = control as StatusStrip;
                if (strip != null) StatusStripTheme(strip);

                ListView list = control as ListView;
                if (list != null) ListViewTheme(list);

                ComboBox cb = control as ComboBox;
                if (cb != null) ComboBoxTheme(cb);

                TextBox tb = control as TextBox;
                if (tb != null) TextBox(tb);

                LinkLabel linkLabel = control as LinkLabel;
                if (linkLabel != null) LinkLabelTheme(linkLabel);

                Panel panel = control as Panel;
                if (panel != null) PanelTheme(panel);

                DataGridView dgv = control as DataGridView;
                if (dgv != null) DataGridTheme(dgv);
            }
            private static void ControlsTheme(Control control)
            {
                CheckControl(control);

                for (int i = 0; i < control.Controls.Count; i++)
                {
                    Button b1 = control.Controls[i] as Button;
                    if (b1 != null) ButtonTheme(b1);

                    CustomDateTimePicker dt1 = control.Controls[i] as CustomDateTimePicker;
                    if (dt1 != null) DateTimePickerTheme(dt1);

                    TabControl c1 = control.Controls[i] as TabControl;
                    if (c1 != null) PagesTheme(c1);

                    GroupBox grp1 = control.Controls[i] as GroupBox;
                    if (grp1 != null) GroupBoxTheme(grp1);

                    StatusStrip strip1 = control.Controls[i] as StatusStrip;
                    if (strip1 != null) StatusStripTheme(strip1);

                    ListView list1 = control.Controls[i] as ListView;
                    if (list1 != null) ListViewTheme(list1);

                    ComboBox cb1 = control.Controls[i] as ComboBox;
                    if (cb1 != null) ComboBoxTheme(cb1);

                    TextBox tb1 = control.Controls[i] as TextBox;
                    if (tb1 != null) TextBox(tb1);

                    LinkLabel linkLabel1 = control.Controls[i] as LinkLabel;
                    if (linkLabel1 != null) LinkLabelTheme(linkLabel1);

                    Panel panel1 = control.Controls[i] as Panel;
                    if(panel1 != null) PanelTheme(panel1);

                    DataGridView dgv = control as DataGridView;
                    if (dgv != null) DataGridTheme(dgv);
                }
            }
            public static void FormStyle(Form form)
            {
                form.BackColor = _currentTheme[ThemeColor.FormBackgound];
                form.ForeColor = _currentTheme[ThemeColor.Text];
               
                for (int i = 0; i < form.Controls.Count; i++)
                {
                    Button b = form.Controls[i] as Button;
                    if (b != null) ButtonTheme(b);

                    CustomDateTimePicker dt = form.Controls[i] as CustomDateTimePicker;
                    if (dt != null) DateTimePickerTheme(dt);

                    TabControl c = form.Controls[i] as TabControl;
                    if (c != null) PagesTheme(c);

                    GroupBox grp = form.Controls[i] as GroupBox;
                    if (grp != null) GroupBoxTheme(grp);

                    StatusStrip strip = form.Controls[i] as StatusStrip;
                    if (strip != null) StatusStripTheme(strip);
                    ListView list = form.Controls[i] as ListView;
                    if (list != null) ListViewTheme(list);

                    ComboBox cb = form.Controls[i] as ComboBox;
                    if (cb != null) ComboBoxTheme(cb);

                    TextBox tb = form.Controls[i] as TextBox;
                    if (tb != null) TextBox(tb);

                    LinkLabel linkLabel = form.Controls[i] as LinkLabel;
                    if (linkLabel != null) LinkLabelTheme(linkLabel);

                    Panel panel = form.Controls[i] as Panel;
                    if (panel != null) PanelTheme(panel);

                    DataGridView dgv = form.Controls[i] as DataGridView;
                    if (dgv != null) DataGridTheme(dgv);
                }
                for (int i = 0; i < form.Controls.Count; i++)
                    ControlsTheme(form.Controls[i]);
            }
            private static void DataGridTheme(DataGridView data)
            {
                data.EnableHeadersVisualStyles = false;
                data.BackgroundColor = _currentTheme[ThemeColor.PageBackGround];
                data.ColumnHeadersDefaultCellStyle.ForeColor = _currentTheme[ThemeColor.Text];
                data.ColumnHeadersDefaultCellStyle.BackColor = _currentTheme[ThemeColor.PageBackGround];
                data.DefaultCellStyle.BackColor = _currentTheme[ThemeColor.PageBackGround];
                data.DefaultCellStyle.SelectionBackColor = _currentTheme[ThemeColor.ButtonBorderColor];
                data.ForeColor = _currentTheme[ThemeColor.Text];
            }
            private static void GroupBoxTheme(GroupBox groupBox)
            {
                groupBox.ForeColor = _currentTheme[ThemeColor.Text];
                
                for(int i = 0;i < groupBox.Controls.Count;i++)
                    ControlsTheme(groupBox.Controls[i]);
            }
            private static void StatusStripTheme(StatusStrip strip)
            {
                strip.BackColor = _currentTheme[ThemeColor.StripBackground];
                strip.ForeColor = _currentTheme[ThemeColor.StripText];
               
                for (int i = 0; i < strip.Controls.Count; i++)
                    ControlsTheme(strip.Controls[i]);
            }
            private static void ListViewTheme(params ListView[] lists)
            {
                foreach (ListView list in lists)
                {
                    list.BackColor = _currentTheme[ThemeColor.ListViewBackGroud];
                    list.ForeColor = _currentTheme[ThemeColor.Text];
                    list.GridLines = false;
                    list.BorderStyle = _borderStyle;
                    foreach (ListViewItem item in list.Items)
                        item.BackColor = _currentTheme[ThemeColor.ButtonBorderColor];
                }
            }
            private static void ComboBoxTheme(ComboBox box)
            {
                box.BackColor = _currentTheme[ThemeColor.ListViewBackGroud];
                box.ForeColor = _currentTheme[ThemeColor.Text];
                box.FlatStyle = _flatStyle;
                for (int i = 0; i < box.Controls.Count; i++)
                    ControlsTheme(box.Controls[i]);
            }
        }
    }
}
