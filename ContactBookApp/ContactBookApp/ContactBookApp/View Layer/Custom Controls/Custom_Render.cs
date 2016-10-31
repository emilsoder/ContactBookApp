//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Drawing;
//using System.Windows.Forms;

//namespace ContactBookApp.View_Layer.Custom_Controls
//{

//    public class InitializeCustomControls
//    {
//        public void initializeRenderer(MainView mainView)
//        {
//            mainView.dataGridView1.DefaultCellStyle. = new DataGridViewAdvancedBorderStyle(new TestColorTable());
//        }
//    }

//    public class TestColorTable : ProfessionalColorTable
//    {
//        #region Colors
//        Color mainColor = Color.WhiteSmoke;
//        Color hotTrackColor = Color.Gainsboro;
//        #endregion

//        #region Check Renderer Configuration
//        public override Color CheckBackground
//        {
//            get
//            {
//                return Color.SteelBlue;
//            }
//        }
//        public override Color ButtonCheckedGradientBegin
//        {
//            get
//            {
//                return Color.SteelBlue;
//            }
//        }
//        public override Color ButtonCheckedGradientEnd
//        {
//            get
//            {
//                return Color.SteelBlue;
//            }
//        }
//        public override Color ButtonCheckedHighlight
//        {
//            get
//            {
//                return Color.SteelBlue;
//            }
//        }
//        public override Color CheckPressedBackground
//        {
//            get
//            {
//                return Color.SteelBlue;
//            }
//        }
//        public override Color CheckSelectedBackground
//        {
//            get { return mainColor; }
//        }
//        #endregion

//        #region Control Color Renderer
//        public override Color MenuItemSelected
//        {
//            get { return Color.SlateGray; }
//        }
//        public override Color MenuBorder
//        {
//            get { return Color.Gray; }
//        }
//        public override Color MenuItemBorder
//        {
//            get { return Color.Gray; }
//        }
//        public override Color MenuItemSelectedGradientBegin
//        {
//            get { return mainColor; }
//        }
//        public override Color MenuItemSelectedGradientEnd
//        {
//            get { return mainColor; }
//        }
//        public override Color MenuItemPressedGradientBegin
//        {
//            get { return mainColor; }
//        }
//        public override Color MenuItemPressedGradientEnd
//        {
//            get { return mainColor; }
//        }

//        public override Color ToolStripDropDownBackground
//        {
//            get { return mainColor; }
//        }
//        public override Color ImageMarginGradientBegin
//        {
//            get { return mainColor; }
//        }
//        public override Color ImageMarginGradientMiddle
//        {
//            get { return mainColor; }
//        }
//        public override Color ImageMarginGradientEnd
//        {
//            get { return mainColor; }
//        }
//        #endregion
//    }
//}
