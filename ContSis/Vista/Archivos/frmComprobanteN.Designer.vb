﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmComprobanteN
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComprobanteN))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblnomFP = New System.Windows.Forms.Label()
        Me.txtFormapago = New System.Windows.Forms.TextBox()
        Me.rbtEfectivo = New System.Windows.Forms.RadioButton()
        Me.rbtBanco = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtInafecto = New System.Windows.Forms.TextBox()
        Me.txtCuentaInafecto = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnumcompro = New System.Windows.Forms.TextBox()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIsc = New System.Windows.Forms.TextBox()
        Me.txtIgv = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.cboAdq = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCuentaTotal = New System.Windows.Forms.TextBox()
        Me.txtCuentaIgv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCuentaIsc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCuentaMonto = New System.Windows.Forms.TextBox()
        Me.cbotipodoc = New System.Windows.Forms.ComboBox()
        Me.txtDserie = New System.Windows.Forms.TextBox()
        Me.txtDnumero = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ErrorIcon = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtdia = New System.Windows.Forms.TextBox()
        Me.chbfechav = New System.Windows.Forms.CheckBox()
        Me.lblFechaemision = New System.Windows.Forms.Label()
        Me.txtañov = New System.Windows.Forms.TextBox()
        Me.txtmes = New System.Windows.Forms.TextBox()
        Me.txtmesv = New System.Windows.Forms.TextBox()
        Me.txtaño = New System.Windows.Forms.TextBox()
        Me.txtdiav = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbguardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbcancelar = New System.Windows.Forms.ToolStripButton()
        Me.tsbeliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbsalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbexportar = New System.Windows.Forms.ToolStripButton()
        Me.tsbimportar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblnomFP)
        Me.GroupBox1.Controls.Add(Me.txtFormapago)
        Me.GroupBox1.Controls.Add(Me.rbtEfectivo)
        Me.GroupBox1.Controls.Add(Me.rbtBanco)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(407, 359)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(239, 135)
        Me.GroupBox1.TabIndex = 318
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMA DE  PAGO"
        '
        'lblnomFP
        '
        Me.lblnomFP.BackColor = System.Drawing.Color.White
        Me.lblnomFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomFP.Location = New System.Drawing.Point(10, 90)
        Me.lblnomFP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnomFP.MaximumSize = New System.Drawing.Size(407, 17)
        Me.lblnomFP.Name = "lblnomFP"
        Me.lblnomFP.Size = New System.Drawing.Size(221, 17)
        Me.lblnomFP.TabIndex = 320
        Me.lblnomFP.Text = "Nombre de Cuenta"
        '
        'txtFormapago
        '
        Me.txtFormapago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtFormapago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtFormapago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFormapago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormapago.Location = New System.Drawing.Point(13, 57)
        Me.txtFormapago.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFormapago.Name = "txtFormapago"
        Me.txtFormapago.Size = New System.Drawing.Size(103, 21)
        Me.txtFormapago.TabIndex = 319
        '
        'rbtEfectivo
        '
        Me.rbtEfectivo.AutoSize = True
        Me.rbtEfectivo.Checked = True
        Me.rbtEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbtEfectivo.Location = New System.Drawing.Point(13, 22)
        Me.rbtEfectivo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbtEfectivo.Name = "rbtEfectivo"
        Me.rbtEfectivo.Size = New System.Drawing.Size(66, 19)
        Me.rbtEfectivo.TabIndex = 228
        Me.rbtEfectivo.TabStop = True
        Me.rbtEfectivo.Text = "Efectivo"
        Me.rbtEfectivo.UseVisualStyleBackColor = True
        '
        'rbtBanco
        '
        Me.rbtBanco.AutoSize = True
        Me.rbtBanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbtBanco.Location = New System.Drawing.Point(103, 22)
        Me.rbtBanco.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbtBanco.Name = "rbtBanco"
        Me.rbtBanco.Size = New System.Drawing.Size(59, 19)
        Me.rbtBanco.TabIndex = 229
        Me.rbtBanco.Text = "Banco"
        Me.rbtBanco.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(59, 419)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 18)
        Me.Label9.TabIndex = 317
        Me.Label9.Text = "Inafecto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtInafecto
        '
        Me.txtInafecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInafecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInafecto.Location = New System.Drawing.Point(140, 419)
        Me.txtInafecto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtInafecto.Name = "txtInafecto"
        Me.txtInafecto.Size = New System.Drawing.Size(98, 21)
        Me.txtInafecto.TabIndex = 316
        Me.txtInafecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCuentaInafecto
        '
        Me.txtCuentaInafecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCuentaInafecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCuentaInafecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaInafecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaInafecto.Location = New System.Drawing.Point(271, 419)
        Me.txtCuentaInafecto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCuentaInafecto.Name = "txtCuentaInafecto"
        Me.txtCuentaInafecto.Size = New System.Drawing.Size(113, 21)
        Me.txtCuentaInafecto.TabIndex = 315
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(17, 64)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(101, 15)
        Me.Label20.TabIndex = 313
        Me.Label20.Text = "Nº  Comprobante"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(65, 269)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 15)
        Me.Label8.TabIndex = 312
        Me.Label8.Text = "Moneda"
        '
        'txtnumcompro
        '
        Me.txtnumcompro.Enabled = False
        Me.txtnumcompro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumcompro.Location = New System.Drawing.Point(143, 64)
        Me.txtnumcompro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtnumcompro.MaxLength = 4
        Me.txtnumcompro.Name = "txtnumcompro"
        Me.txtnumcompro.Size = New System.Drawing.Size(74, 21)
        Me.txtnumcompro.TabIndex = 314
        '
        'cbomoneda
        '
        Me.cbomoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbomoneda.FormattingEnabled = True
        Me.cbomoneda.Location = New System.Drawing.Point(143, 270)
        Me.cbomoneda.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(95, 23)
        Me.cbomoneda.TabIndex = 284
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(271, 332)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 15)
        Me.Label7.TabIndex = 311
        Me.Label7.Text = "Cuenta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboPeriodo
        '
        Me.CboPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPeriodo.FormattingEnabled = True
        Me.CboPeriodo.Location = New System.Drawing.Point(539, 61)
        Me.CboPeriodo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CboPeriodo.Name = "CboPeriodo"
        Me.CboPeriodo.Size = New System.Drawing.Size(81, 23)
        Me.CboPeriodo.TabIndex = 275
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(471, 61)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 15)
        Me.Label10.TabIndex = 310
        Me.Label10.Text = "Periodo"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(140, 476)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(98, 21)
        Me.txtTotal.TabIndex = 293
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIsc
        '
        Me.txtIsc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIsc.Location = New System.Drawing.Point(140, 449)
        Me.txtIsc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtIsc.Name = "txtIsc"
        Me.txtIsc.Size = New System.Drawing.Size(98, 21)
        Me.txtIsc.TabIndex = 291
        Me.txtIsc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIgv
        '
        Me.txtIgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIgv.Location = New System.Drawing.Point(140, 389)
        Me.txtIgv.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(98, 21)
        Me.txtIgv.TabIndex = 289
        Me.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonto
        '
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(140, 359)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(98, 21)
        Me.txtMonto.TabIndex = 287
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 302)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 309
        Me.Label2.Text = "Glosa"
        '
        'txtGlosa
        '
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(143, 299)
        Me.txtGlosa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(221, 21)
        Me.txtGlosa.TabIndex = 285
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(225, 59)
        Me.btnlimpiar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(88, 27)
        Me.btnlimpiar.TabIndex = 295
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.BackColor = System.Drawing.Color.White
        Me.lblRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.Location = New System.Drawing.Point(143, 229)
        Me.lblRazonSocial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRazonSocial.MaximumSize = New System.Drawing.Size(407, 17)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(221, 17)
        Me.lblRazonSocial.TabIndex = 307
        Me.lblRazonSocial.Text = "Razón Social"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(255, 205)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 21)
        Me.Button3.TabIndex = 283
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(89, 205)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(29, 15)
        Me.Label28.TabIndex = 306
        Me.Label28.Text = "Ruc"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRuc
        '
        Me.txtRuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtRuc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(143, 205)
        Me.txtRuc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(95, 21)
        Me.txtRuc.TabIndex = 282
        '
        'cboAdq
        '
        Me.cboAdq.DropDownWidth = 340
        Me.cboAdq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAdq.FormattingEnabled = True
        Me.cboAdq.Items.AddRange(New Object() {"GRAVADAS Y/O DE EXPORTACIÓN", "GRAVADAS Y/O DE EXPORTACIÓN Y A OPERACIONES NO GRAVADAS", "OPERACIONES NO GRAVADAS"})
        Me.cboAdq.Location = New System.Drawing.Point(143, 153)
        Me.cboAdq.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboAdq.Name = "cboAdq"
        Me.cboAdq.Size = New System.Drawing.Size(221, 21)
        Me.cboAdq.TabIndex = 281
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 148)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 40)
        Me.Label6.TabIndex = 305
        Me.Label6.Text = "Adq. Gravadas Dest. a Oper."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCuentaTotal
        '
        Me.txtCuentaTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCuentaTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCuentaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaTotal.Location = New System.Drawing.Point(271, 476)
        Me.txtCuentaTotal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCuentaTotal.Name = "txtCuentaTotal"
        Me.txtCuentaTotal.Size = New System.Drawing.Size(113, 21)
        Me.txtCuentaTotal.TabIndex = 292
        '
        'txtCuentaIgv
        '
        Me.txtCuentaIgv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCuentaIgv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCuentaIgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaIgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaIgv.Location = New System.Drawing.Point(271, 389)
        Me.txtCuentaIgv.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCuentaIgv.Name = "txtCuentaIgv"
        Me.txtCuentaIgv.Size = New System.Drawing.Size(113, 21)
        Me.txtCuentaIgv.TabIndex = 288
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 476)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 18)
        Me.Label5.TabIndex = 304
        Me.Label5.Text = "Total"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 389)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 18)
        Me.Label4.TabIndex = 303
        Me.Label4.Text = "IGV"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 449)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 18)
        Me.Label3.TabIndex = 302
        Me.Label3.Text = "ISC"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCuentaIsc
        '
        Me.txtCuentaIsc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCuentaIsc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCuentaIsc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaIsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaIsc.Location = New System.Drawing.Point(271, 449)
        Me.txtCuentaIsc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCuentaIsc.Name = "txtCuentaIsc"
        Me.txtCuentaIsc.Size = New System.Drawing.Size(113, 21)
        Me.txtCuentaIsc.TabIndex = 290
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 359)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 301
        Me.Label1.Text = "Monto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCuentaMonto
        '
        Me.txtCuentaMonto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCuentaMonto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCuentaMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaMonto.Location = New System.Drawing.Point(271, 359)
        Me.txtCuentaMonto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCuentaMonto.Name = "txtCuentaMonto"
        Me.txtCuentaMonto.Size = New System.Drawing.Size(113, 21)
        Me.txtCuentaMonto.TabIndex = 286
        '
        'cbotipodoc
        '
        Me.cbotipodoc.DropDownWidth = 300
        Me.cbotipodoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotipodoc.FormattingEnabled = True
        Me.cbotipodoc.Location = New System.Drawing.Point(143, 93)
        Me.cbotipodoc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbotipodoc.Name = "cbotipodoc"
        Me.cbotipodoc.Size = New System.Drawing.Size(174, 23)
        Me.cbotipodoc.TabIndex = 276
        '
        'txtDserie
        '
        Me.txtDserie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDserie.Location = New System.Drawing.Point(143, 124)
        Me.txtDserie.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDserie.MaxLength = 3
        Me.txtDserie.Name = "txtDserie"
        Me.txtDserie.Size = New System.Drawing.Size(40, 21)
        Me.txtDserie.TabIndex = 277
        '
        'txtDnumero
        '
        Me.txtDnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDnumero.Location = New System.Drawing.Point(201, 124)
        Me.txtDnumero.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDnumero.MaxLength = 7
        Me.txtDnumero.Name = "txtDnumero"
        Me.txtDnumero.Size = New System.Drawing.Size(88, 21)
        Me.txtDnumero.TabIndex = 278
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(31, 126)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(87, 15)
        Me.Label24.TabIndex = 299
        Me.Label24.Text = "Nº Documento"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(20, 98)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(98, 15)
        Me.Label25.TabIndex = 298
        Me.Label25.Text = "Tipo Documento"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorIcon
        '
        Me.ErrorIcon.ContainerControl = Me
        Me.ErrorIcon.Icon = CType(resources.GetObject("ErrorIcon.Icon"), System.Drawing.Icon)
        '
        'txtdia
        '
        Me.txtdia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdia.Location = New System.Drawing.Point(544, 105)
        Me.txtdia.MaxLength = 2
        Me.txtdia.Name = "txtdia"
        Me.txtdia.Size = New System.Drawing.Size(20, 20)
        Me.txtdia.TabIndex = 320
        Me.txtdia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chbfechav
        '
        Me.chbfechav.AutoSize = True
        Me.chbfechav.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chbfechav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbfechav.Location = New System.Drawing.Point(431, 136)
        Me.chbfechav.Name = "chbfechav"
        Me.chbfechav.Size = New System.Drawing.Size(93, 17)
        Me.chbfechav.TabIndex = 326
        Me.chbfechav.Text = "Fecha Vencimi"
        Me.chbfechav.UseVisualStyleBackColor = True
        '
        'lblFechaemision
        '
        Me.lblFechaemision.AutoSize = True
        Me.lblFechaemision.Location = New System.Drawing.Point(432, 109)
        Me.lblFechaemision.Name = "lblFechaemision"
        Me.lblFechaemision.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaemision.TabIndex = 319
        Me.lblFechaemision.Text = "Fecha Emisión"
        '
        'txtañov
        '
        Me.txtañov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtañov.Enabled = False
        Me.txtañov.Location = New System.Drawing.Point(582, 134)
        Me.txtañov.MaxLength = 4
        Me.txtañov.Name = "txtañov"
        Me.txtañov.Size = New System.Drawing.Size(37, 20)
        Me.txtañov.TabIndex = 325
        Me.txtañov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmes
        '
        Me.txtmes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmes.Location = New System.Drawing.Point(563, 105)
        Me.txtmes.MaxLength = 2
        Me.txtmes.Name = "txtmes"
        Me.txtmes.Size = New System.Drawing.Size(20, 20)
        Me.txtmes.TabIndex = 321
        Me.txtmes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmesv
        '
        Me.txtmesv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmesv.Enabled = False
        Me.txtmesv.Location = New System.Drawing.Point(563, 134)
        Me.txtmesv.MaxLength = 2
        Me.txtmesv.Name = "txtmesv"
        Me.txtmesv.Size = New System.Drawing.Size(20, 20)
        Me.txtmesv.TabIndex = 324
        Me.txtmesv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtaño
        '
        Me.txtaño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaño.Location = New System.Drawing.Point(582, 105)
        Me.txtaño.MaxLength = 4
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(37, 20)
        Me.txtaño.TabIndex = 322
        Me.txtaño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdiav
        '
        Me.txtdiav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiav.Enabled = False
        Me.txtdiav.Location = New System.Drawing.Point(544, 134)
        Me.txtdiav.MaxLength = 2
        Me.txtdiav.Name = "txtdiav"
        Me.txtdiav.Size = New System.Drawing.Size(20, 20)
        Me.txtdiav.TabIndex = 323
        Me.txtdiav.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbguardar, Me.tsbcancelar, Me.tsbeliminar, Me.tsbsalir, Me.ToolStripSeparator1, Me.tsbexportar, Me.tsbimportar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(659, 53)
        Me.ToolStrip1.TabIndex = 327
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbguardar
        '
        Me.tsbguardar.AutoSize = False
        Me.tsbguardar.Image = Global.Vista.My.Resources.Resources.guardar
        Me.tsbguardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbguardar.Name = "tsbguardar"
        Me.tsbguardar.Size = New System.Drawing.Size(100, 50)
        Me.tsbguardar.Text = "Guardar"
        '
        'tsbcancelar
        '
        Me.tsbcancelar.AutoSize = False
        Me.tsbcancelar.Image = Global.Vista.My.Resources.Resources.salir
        Me.tsbcancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbcancelar.Name = "tsbcancelar"
        Me.tsbcancelar.Size = New System.Drawing.Size(100, 47)
        Me.tsbcancelar.Text = "Cancelar"
        '
        'tsbeliminar
        '
        Me.tsbeliminar.AutoSize = False
        Me.tsbeliminar.Image = Global.Vista.My.Resources.Resources.eleminar_true
        Me.tsbeliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbeliminar.Name = "tsbeliminar"
        Me.tsbeliminar.Size = New System.Drawing.Size(100, 47)
        Me.tsbeliminar.Text = "Eliminar"
        '
        'tsbsalir
        '
        Me.tsbsalir.AutoSize = False
        Me.tsbsalir.Image = Global.Vista.My.Resources.Resources.log_logout_door_1563
        Me.tsbsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbsalir.Name = "tsbsalir"
        Me.tsbsalir.Size = New System.Drawing.Size(100, 47)
        Me.tsbsalir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'tsbexportar
        '
        Me.tsbexportar.AutoSize = False
        Me.tsbexportar.Image = Global.Vista.My.Resources.Resources.export_icon
        Me.tsbexportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbexportar.Name = "tsbexportar"
        Me.tsbexportar.Size = New System.Drawing.Size(100, 47)
        Me.tsbexportar.Text = "Exportar"
        '
        'tsbimportar
        '
        Me.tsbimportar.AutoSize = False
        Me.tsbimportar.Image = Global.Vista.My.Resources.Resources.import_icon
        Me.tsbimportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbimportar.Name = "tsbimportar"
        Me.tsbimportar.Size = New System.Drawing.Size(73, 50)
        Me.tsbimportar.Text = "Importar"
        '
        'FrmComprobanteN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 507)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtdia)
        Me.Controls.Add(Me.chbfechav)
        Me.Controls.Add(Me.lblFechaemision)
        Me.Controls.Add(Me.txtañov)
        Me.Controls.Add(Me.txtmes)
        Me.Controls.Add(Me.txtmesv)
        Me.Controls.Add(Me.txtaño)
        Me.Controls.Add(Me.txtdiav)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtInafecto)
        Me.Controls.Add(Me.txtCuentaInafecto)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnumcompro)
        Me.Controls.Add(Me.cbomoneda)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CboPeriodo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtIsc)
        Me.Controls.Add(Me.txtIgv)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGlosa)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.lblRazonSocial)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtRuc)
        Me.Controls.Add(Me.cboAdq)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCuentaTotal)
        Me.Controls.Add(Me.txtCuentaIgv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCuentaIsc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCuentaMonto)
        Me.Controls.Add(Me.cbotipodoc)
        Me.Controls.Add(Me.txtDserie)
        Me.Controls.Add(Me.txtDnumero)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Name = "FrmComprobanteN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Compra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtBanco As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtInafecto As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaInafecto As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnumcompro As System.Windows.Forms.TextBox
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIsc As System.Windows.Forms.TextBox
    Friend WithEvents txtIgv As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents cboAdq As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaIgv As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaIsc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaMonto As System.Windows.Forms.TextBox
    Friend WithEvents cbotipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtDserie As System.Windows.Forms.TextBox
    Friend WithEvents txtDnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ErrorIcon As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblnomFP As System.Windows.Forms.Label
    Friend WithEvents txtFormapago As System.Windows.Forms.TextBox
    Friend WithEvents txtdia As System.Windows.Forms.TextBox
    Friend WithEvents chbfechav As System.Windows.Forms.CheckBox
    Friend WithEvents lblFechaemision As System.Windows.Forms.Label
    Friend WithEvents txtañov As System.Windows.Forms.TextBox
    Friend WithEvents txtmes As System.Windows.Forms.TextBox
    Friend WithEvents txtmesv As System.Windows.Forms.TextBox
    Friend WithEvents txtaño As System.Windows.Forms.TextBox
    Friend WithEvents txtdiav As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbguardar As ToolStripButton
    Friend WithEvents tsbcancelar As ToolStripButton
    Friend WithEvents tsbeliminar As ToolStripButton
    Friend WithEvents tsbsalir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbexportar As ToolStripButton
    Friend WithEvents tsbimportar As ToolStripButton
End Class
