namespace app_drivers.Forms
{
    partial class FormLot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listOnTripLots = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.listDeliveredLots = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.btnRemoveFromDelivered = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnMoveToDelivered = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lotPackagesTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOnTripLots
            // 
            this.listOnTripLots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listOnTripLots.Location = new System.Drawing.Point(12, 72);
            this.listOnTripLots.Name = "listOnTripLots";
            this.listOnTripLots.OverrideFocus.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.listOnTripLots.OverrideFocus.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.listOnTripLots.Size = new System.Drawing.Size(385, 497);
            this.listOnTripLots.StateCheckedPressed.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.listOnTripLots.StateCheckedPressed.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.listOnTripLots.StateCheckedTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.listOnTripLots.StateCheckedTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.listOnTripLots.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.listOnTripLots.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.listOnTripLots.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.listOnTripLots.StateCommon.Border.Rounding = 6;
            this.listOnTripLots.StateCommon.Border.Width = 2;
            this.listOnTripLots.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.listOnTripLots.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.listOnTripLots.StateCommon.Item.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.listOnTripLots.StateCommon.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.listOnTripLots.StateCommon.Item.Border.Color2 = System.Drawing.Color.Transparent;
            this.listOnTripLots.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.listOnTripLots.StateCommon.Item.Border.Rounding = 4;
            this.listOnTripLots.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(5);
            this.listOnTripLots.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.listOnTripLots.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOnTripLots.StateDisabled.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.listOnTripLots.StateDisabled.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.listOnTripLots.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.listOnTripLots.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.listOnTripLots.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.listOnTripLots.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.listOnTripLots.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.listOnTripLots.StateNormal.Item.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.listOnTripLots.StateNormal.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.listOnTripLots.StateNormal.Item.Border.Color2 = System.Drawing.Color.Transparent;
            this.listOnTripLots.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.listOnTripLots.StateNormal.Item.Border.Rounding = 4;
            this.listOnTripLots.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.listOnTripLots.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOnTripLots.StatePressed.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.listOnTripLots.StatePressed.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.listOnTripLots.StatePressed.Item.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.listOnTripLots.StatePressed.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.listOnTripLots.StatePressed.Item.Border.Color2 = System.Drawing.Color.Transparent;
            this.listOnTripLots.StatePressed.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.listOnTripLots.StatePressed.Item.Content.Padding = new System.Windows.Forms.Padding(4);
            this.listOnTripLots.StatePressed.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.listOnTripLots.StatePressed.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOnTripLots.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.listOnTripLots.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.listOnTripLots.TabIndex = 0;
            // 
            // listDeliveredLots
            // 
            this.listDeliveredLots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listDeliveredLots.Location = new System.Drawing.Point(528, 72);
            this.listDeliveredLots.Name = "listDeliveredLots";
            this.listDeliveredLots.Size = new System.Drawing.Size(385, 497);
            this.listDeliveredLots.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.listDeliveredLots.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.listDeliveredLots.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.listDeliveredLots.StateCommon.Border.Rounding = 6;
            this.listDeliveredLots.StateCommon.Border.Width = 2;
            this.listDeliveredLots.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.listDeliveredLots.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.listDeliveredLots.StateCommon.Item.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.listDeliveredLots.StateCommon.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.listDeliveredLots.StateCommon.Item.Border.Color2 = System.Drawing.Color.Transparent;
            this.listDeliveredLots.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.listDeliveredLots.StateCommon.Item.Border.Width = 2;
            this.listDeliveredLots.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(5);
            this.listDeliveredLots.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.listDeliveredLots.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDeliveredLots.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.listDeliveredLots.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.listDeliveredLots.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.listDeliveredLots.StateNormal.Border.Width = 2;
            this.listDeliveredLots.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.listDeliveredLots.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDeliveredLots.TabIndex = 1;
            // 
            // btnRemoveFromDelivered
            // 
            this.btnRemoveFromDelivered.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveFromDelivered.Enabled = false;
            this.btnRemoveFromDelivered.Location = new System.Drawing.Point(411, 328);
            this.btnRemoveFromDelivered.Name = "btnRemoveFromDelivered";
            this.btnRemoveFromDelivered.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromDelivered.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromDelivered.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromDelivered.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromDelivered.Size = new System.Drawing.Size(102, 43);
            this.btnRemoveFromDelivered.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromDelivered.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromDelivered.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemoveFromDelivered.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnRemoveFromDelivered.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold);
            this.btnRemoveFromDelivered.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnRemoveFromDelivered.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnRemoveFromDelivered.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemoveFromDelivered.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromDelivered.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromDelivered.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromDelivered.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnRemoveFromDelivered.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnRemoveFromDelivered.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnRemoveFromDelivered.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemoveFromDelivered.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemoveFromDelivered.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromDelivered.StateNormal.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.btnRemoveFromDelivered.StateNormal.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnRemoveFromDelivered.StateNormal.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnRemoveFromDelivered.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnRemoveFromDelivered.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnRemoveFromDelivered.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromDelivered.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromDelivered.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromDelivered.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromDelivered.TabIndex = 14;
            this.btnRemoveFromDelivered.Values.Text = "<";
            this.btnRemoveFromDelivered.Click += new System.EventHandler(this.btnRemoveFromDelivered_Click);
            // 
            // btnMoveToDelivered
            // 
            this.btnMoveToDelivered.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMoveToDelivered.Enabled = false;
            this.btnMoveToDelivered.Location = new System.Drawing.Point(411, 265);
            this.btnMoveToDelivered.Name = "btnMoveToDelivered";
            this.btnMoveToDelivered.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToDelivered.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToDelivered.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnMoveToDelivered.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnMoveToDelivered.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoveToDelivered.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMoveToDelivered.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMoveToDelivered.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToDelivered.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToDelivered.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToDelivered.Size = new System.Drawing.Size(102, 43);
            this.btnMoveToDelivered.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToDelivered.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToDelivered.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMoveToDelivered.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMoveToDelivered.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold);
            this.btnMoveToDelivered.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnMoveToDelivered.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnMoveToDelivered.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMoveToDelivered.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMoveToDelivered.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToDelivered.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToDelivered.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToDelivered.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMoveToDelivered.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnMoveToDelivered.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnMoveToDelivered.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoveToDelivered.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMoveToDelivered.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMoveToDelivered.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToDelivered.StateNormal.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.btnMoveToDelivered.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToDelivered.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToDelivered.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToDelivered.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToDelivered.TabIndex = 13;
            this.btnMoveToDelivered.Values.Text = ">";
            this.btnMoveToDelivered.Click += new System.EventHandler(this.btnMoveToDelivered_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lotes sin entregar";
            // 
            // lotPackagesTitle
            // 
            this.lotPackagesTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lotPackagesTitle.AutoSize = true;
            this.lotPackagesTitle.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotPackagesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotPackagesTitle.Location = new System.Drawing.Point(521, 18);
            this.lotPackagesTitle.Name = "lotPackagesTitle";
            this.lotPackagesTitle.Size = new System.Drawing.Size(243, 42);
            this.lotPackagesTitle.TabIndex = 8;
            this.lotPackagesTitle.Text = "Lotes entregados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lotPackagesTitle);
            this.panel1.Controls.Add(this.listOnTripLots);
            this.panel1.Controls.Add(this.listDeliveredLots);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 581);
            this.panel1.TabIndex = 15;
            // 
            // FormLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 581);
            this.Controls.Add(this.btnRemoveFromDelivered);
            this.Controls.Add(this.btnMoveToDelivered);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(941, 620);
            this.Name = "FormLot";
            this.Text = "Lotes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonListBox listOnTripLots;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox listDeliveredLots;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRemoveFromDelivered;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMoveToDelivered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lotPackagesTitle;
        private System.Windows.Forms.Panel panel1;
    }
}