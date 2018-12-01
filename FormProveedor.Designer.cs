namespace Win.Rentas
{
    partial class FormProveedor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label correoElectronicoLabel;
            System.Windows.Forms.Label direccionProveLabel;
            System.Windows.Forms.Label idProveLabel;
            System.Windows.Forms.Label nombreProveLabel;
            System.Windows.Forms.Label telefonoProveLabel;
            System.Windows.Forms.Label activoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedor));
            this.infoProveedorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.infoProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.infoProveedorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.correoElectronicoTextBox = new System.Windows.Forms.TextBox();
            this.direccionProveTextBox = new System.Windows.Forms.TextBox();
            this.idProveTextBox = new System.Windows.Forms.TextBox();
            this.nombreProveTextBox = new System.Windows.Forms.TextBox();
            this.telefonoProveTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            correoElectronicoLabel = new System.Windows.Forms.Label();
            direccionProveLabel = new System.Windows.Forms.Label();
            idProveLabel = new System.Windows.Forms.Label();
            nombreProveLabel = new System.Windows.Forms.Label();
            telefonoProveLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoProveedorBindingNavigator)).BeginInit();
            this.infoProveedorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.Location = new System.Drawing.Point(27, 122);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(97, 13);
            correoElectronicoLabel.TabIndex = 1;
            correoElectronicoLabel.Text = "Correo Electronico:";
            // 
            // direccionProveLabel
            // 
            direccionProveLabel.AutoSize = true;
            direccionProveLabel.Location = new System.Drawing.Point(27, 148);
            direccionProveLabel.Name = "direccionProveLabel";
            direccionProveLabel.Size = new System.Drawing.Size(55, 13);
            direccionProveLabel.TabIndex = 3;
            direccionProveLabel.Text = "Dirección:";
            // 
            // idProveLabel
            // 
            idProveLabel.AutoSize = true;
            idProveLabel.Location = new System.Drawing.Point(27, 46);
            idProveLabel.Name = "idProveLabel";
            idProveLabel.Size = new System.Drawing.Size(19, 13);
            idProveLabel.TabIndex = 5;
            idProveLabel.Text = "Id:";
            // 
            // nombreProveLabel
            // 
            nombreProveLabel.AutoSize = true;
            nombreProveLabel.Location = new System.Drawing.Point(27, 71);
            nombreProveLabel.Name = "nombreProveLabel";
            nombreProveLabel.Size = new System.Drawing.Size(47, 13);
            nombreProveLabel.TabIndex = 7;
            nombreProveLabel.Text = "Nombre:";
            // 
            // telefonoProveLabel
            // 
            telefonoProveLabel.AutoSize = true;
            telefonoProveLabel.Location = new System.Drawing.Point(27, 97);
            telefonoProveLabel.Name = "telefonoProveLabel";
            telefonoProveLabel.Size = new System.Drawing.Size(52, 13);
            telefonoProveLabel.TabIndex = 9;
            telefonoProveLabel.Text = "Teléfono:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(27, 179);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 11;
            activoLabel.Text = "Activo:";
            // 
            // infoProveedorBindingNavigator
            // 
            this.infoProveedorBindingNavigator.AddNewItem = null;
            this.infoProveedorBindingNavigator.BindingSource = this.infoProveedorBindingSource;
            this.infoProveedorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.infoProveedorBindingNavigator.DeleteItem = null;
            this.infoProveedorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.infoProveedorBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.infoProveedorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.infoProveedorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.infoProveedorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.infoProveedorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.infoProveedorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.infoProveedorBindingNavigator.Name = "infoProveedorBindingNavigator";
            this.infoProveedorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.infoProveedorBindingNavigator.Size = new System.Drawing.Size(570, 25);
            this.infoProveedorBindingNavigator.TabIndex = 0;
            this.infoProveedorBindingNavigator.Text = "bindingNavigator1";
            this.infoProveedorBindingNavigator.RefreshItems += new System.EventHandler(this.infoProveedorBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // infoProveedorBindingSource
            // 
            this.infoProveedorBindingSource.DataSource = typeof(BL.Rentas.Proveedor);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // infoProveedorBindingNavigatorSaveItem
            // 
            this.infoProveedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.infoProveedorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("infoProveedorBindingNavigatorSaveItem.Image")));
            this.infoProveedorBindingNavigatorSaveItem.Name = "infoProveedorBindingNavigatorSaveItem";
            this.infoProveedorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.infoProveedorBindingNavigatorSaveItem.Text = "Guardar datos";
            this.infoProveedorBindingNavigatorSaveItem.Click += new System.EventHandler(this.infoProveedorBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // correoElectronicoTextBox
            // 
            this.correoElectronicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infoProveedorBindingSource, "CorreoElectronico", true));
            this.correoElectronicoTextBox.Location = new System.Drawing.Point(130, 119);
            this.correoElectronicoTextBox.Name = "correoElectronicoTextBox";
            this.correoElectronicoTextBox.Size = new System.Drawing.Size(341, 20);
            this.correoElectronicoTextBox.TabIndex = 3;
            // 
            // direccionProveTextBox
            // 
            this.direccionProveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infoProveedorBindingSource, "DireccionProve", true));
            this.direccionProveTextBox.Location = new System.Drawing.Point(130, 145);
            this.direccionProveTextBox.Name = "direccionProveTextBox";
            this.direccionProveTextBox.Size = new System.Drawing.Size(341, 20);
            this.direccionProveTextBox.TabIndex = 4;
            // 
            // idProveTextBox
            // 
            this.idProveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infoProveedorBindingSource, "IdProve", true));
            this.idProveTextBox.Location = new System.Drawing.Point(130, 43);
            this.idProveTextBox.Name = "idProveTextBox";
            this.idProveTextBox.ReadOnly = true;
            this.idProveTextBox.Size = new System.Drawing.Size(85, 20);
            this.idProveTextBox.TabIndex = 6;
            // 
            // nombreProveTextBox
            // 
            this.nombreProveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infoProveedorBindingSource, "NombreProve", true));
            this.nombreProveTextBox.Location = new System.Drawing.Point(130, 68);
            this.nombreProveTextBox.Name = "nombreProveTextBox";
            this.nombreProveTextBox.Size = new System.Drawing.Size(341, 20);
            this.nombreProveTextBox.TabIndex = 1;
            // 
            // telefonoProveTextBox
            // 
            this.telefonoProveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infoProveedorBindingSource, "TelefonoProve", true));
            this.telefonoProveTextBox.Location = new System.Drawing.Point(130, 94);
            this.telefonoProveTextBox.Name = "telefonoProveTextBox";
            this.telefonoProveTextBox.Size = new System.Drawing.Size(178, 20);
            this.telefonoProveTextBox.TabIndex = 2;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.infoProveedorBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(130, 174);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 12;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(BL.Rentas.Producto);
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 212);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(correoElectronicoLabel);
            this.Controls.Add(this.correoElectronicoTextBox);
            this.Controls.Add(direccionProveLabel);
            this.Controls.Add(this.direccionProveTextBox);
            this.Controls.Add(idProveLabel);
            this.Controls.Add(this.idProveTextBox);
            this.Controls.Add(nombreProveLabel);
            this.Controls.Add(this.nombreProveTextBox);
            this.Controls.Add(telefonoProveLabel);
            this.Controls.Add(this.telefonoProveTextBox);
            this.Controls.Add(this.infoProveedorBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Proveedor";
            this.Load += new System.EventHandler(this.FormProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoProveedorBindingNavigator)).EndInit();
            this.infoProveedorBindingNavigator.ResumeLayout(false);
            this.infoProveedorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource infoProveedorBindingSource;
        private System.Windows.Forms.BindingNavigator infoProveedorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton infoProveedorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox correoElectronicoTextBox;
        private System.Windows.Forms.TextBox direccionProveTextBox;
        private System.Windows.Forms.TextBox idProveTextBox;
        private System.Windows.Forms.TextBox nombreProveTextBox;
        private System.Windows.Forms.TextBox telefonoProveTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.BindingSource productoBindingSource;
    }
}