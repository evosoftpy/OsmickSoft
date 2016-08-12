<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.DataSet1 = New nuevo_repuestos.DataSet1()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New nuevo_repuestos.DataSet1TableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New nuevo_repuestos.DataSet1TableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.DataSet1
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.ingresoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = nuevo_repuestos.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Stock"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(164, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ventas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(316, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Clientes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(468, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(145, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Proveedores"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(619, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(146, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Informe"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 566)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As DataSet1TableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
