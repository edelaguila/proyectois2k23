﻿
namespace CapaVista
{
    partial class Pedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_total_detalle = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_almacen_detalle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_codigo_producto = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_precio_unitario = new System.Windows.Forms.TextBox();
            this.txt_orden_detalle_venta = new System.Windows.Forms.TextBox();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.txt_id_venta = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_clientes = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_almacen = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(532, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pedido";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(259, 70);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(768, 190);
            this.navegador1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_total_detalle);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txt_almacen_detalle);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btn_modificar);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.txt_codigo_producto);
            this.groupBox2.Controls.Add(this.txt_Precio);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txt_precio_unitario);
            this.groupBox2.Controls.Add(this.txt_orden_detalle_venta);
            this.groupBox2.Controls.Add(this.txt_Estado);
            this.groupBox2.Controls.Add(this.txt_id_venta);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(753, 273);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(509, 359);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle venta";
            // 
            // txt_total_detalle
            // 
            this.txt_total_detalle.Location = new System.Drawing.Point(300, 239);
            this.txt_total_detalle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_total_detalle.Name = "txt_total_detalle";
            this.txt_total_detalle.Size = new System.Drawing.Size(129, 22);
            this.txt_total_detalle.TabIndex = 36;
            this.txt_total_detalle.Tag = "tbl_detalle_venta,Total_detalleventa";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(8, 241);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 20);
            this.label23.TabIndex = 35;
            this.label23.Text = "Estado";
            // 
            // txt_almacen_detalle
            // 
            this.txt_almacen_detalle.Location = new System.Drawing.Point(300, 33);
            this.txt_almacen_detalle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_almacen_detalle.Name = "txt_almacen_detalle";
            this.txt_almacen_detalle.Size = new System.Drawing.Size(129, 22);
            this.txt_almacen_detalle.TabIndex = 34;
            this.txt_almacen_detalle.Tag = "tbl_detalle_venta,Almacen,primary";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(8, 33);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 20);
            this.label16.TabIndex = 33;
            this.label16.Tag = "Pk_idVendedores";
            this.label16.Text = "Id Detalle";
            // 
            // btn_modificar
            // 
            this.btn_modificar.ForeColor = System.Drawing.Color.Black;
            this.btn_modificar.Location = new System.Drawing.Point(165, 311);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(129, 26);
            this.btn_modificar.TabIndex = 27;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminar.Location = new System.Drawing.Point(300, 311);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(129, 26);
            this.btn_eliminar.TabIndex = 28;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // txt_codigo_producto
            // 
            this.txt_codigo_producto.Location = new System.Drawing.Point(300, 138);
            this.txt_codigo_producto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo_producto.Name = "txt_codigo_producto";
            this.txt_codigo_producto.Size = new System.Drawing.Size(129, 22);
            this.txt_codigo_producto.TabIndex = 32;
            this.txt_codigo_producto.Tag = "tbl_detalle_venta,codigo_producto,primary";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(300, 176);
            this.txt_Precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(129, 22);
            this.txt_Precio.TabIndex = 31;
            this.txt_Precio.Tag = "tbl_detalle_venta,Cantidad_detalleventa";
            // 
            // btn_guardar
            // 
            this.btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_guardar.Location = new System.Drawing.Point(30, 311);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(129, 26);
            this.btn_guardar.TabIndex = 26;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(8, 139);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 20);
            this.label17.TabIndex = 30;
            this.label17.Text = "Cantidad";
            // 
            // txt_precio_unitario
            // 
            this.txt_precio_unitario.Location = new System.Drawing.Point(300, 210);
            this.txt_precio_unitario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio_unitario.Name = "txt_precio_unitario";
            this.txt_precio_unitario.Size = new System.Drawing.Size(129, 22);
            this.txt_precio_unitario.TabIndex = 28;
            this.txt_precio_unitario.Tag = "tbl_detalle_venta,Precio_uni_detalleventa";
            // 
            // txt_orden_detalle_venta
            // 
            this.txt_orden_detalle_venta.Location = new System.Drawing.Point(300, 70);
            this.txt_orden_detalle_venta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_orden_detalle_venta.Name = "txt_orden_detalle_venta";
            this.txt_orden_detalle_venta.Size = new System.Drawing.Size(129, 22);
            this.txt_orden_detalle_venta.TabIndex = 27;
            this.txt_orden_detalle_venta.Tag = "tbl_detalle_venta,PK_orden_detalleventa,primary";
            // 
            // txt_Estado
            // 
            this.txt_Estado.Location = new System.Drawing.Point(300, 269);
            this.txt_Estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(129, 22);
            this.txt_Estado.TabIndex = 26;
            this.txt_Estado.Tag = "tbl_detalle_venta,Estado_detalleventa";
            // 
            // txt_id_venta
            // 
            this.txt_id_venta.Location = new System.Drawing.Point(300, 106);
            this.txt_id_venta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_venta.Name = "txt_id_venta";
            this.txt_id_venta.Size = new System.Drawing.Size(129, 22);
            this.txt_id_venta.TabIndex = 25;
            this.txt_id_venta.Tag = "tbl_detalle_venta,Pk_idVenta,primary";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(8, 176);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 20);
            this.label19.TabIndex = 24;
            this.label19.Text = "Precio unitario";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(8, 71);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 20);
            this.label20.TabIndex = 23;
            this.label20.Text = "Id Pedido";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(8, 210);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 20);
            this.label21.TabIndex = 22;
            this.label21.Text = "Total";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(8, 107);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(142, 20);
            this.label22.TabIndex = 21;
            this.label22.Text = "Codigo Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_clientes);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_almacen);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(46, 273);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(683, 359);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // txt_clientes
            // 
            this.txt_clientes.Location = new System.Drawing.Point(164, 155);
            this.txt_clientes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_clientes.Name = "txt_clientes";
            this.txt_clientes.Size = new System.Drawing.Size(108, 22);
            this.txt_clientes.TabIndex = 41;
            this.txt_clientes.Tag = "tbl_pedido,Pk_idClientes";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(164, 115);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(108, 22);
            this.txt_fecha.TabIndex = 40;
            this.txt_fecha.Tag = "tbl_pedido,Fecha_pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Id Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fecha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Id";
            // 
            // txt_almacen
            // 
            this.txt_almacen.Location = new System.Drawing.Point(160, 73);
            this.txt_almacen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_almacen.Name = "txt_almacen";
            this.txt_almacen.Size = new System.Drawing.Size(112, 22);
            this.txt_almacen.TabIndex = 26;
            this.txt_almacen.Tag = "tbl_pedido,Almacen,primary";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(160, 33);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(112, 22);
            this.txt_id.TabIndex = 25;
            this.txt_id.Tag = "tbl_pedido,Pk_idPedido,primary";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(23, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Almacen";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1307, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label1);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_total_detalle;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_almacen_detalle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_codigo_producto;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_precio_unitario;
        private System.Windows.Forms.TextBox txt_orden_detalle_venta;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_id_venta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_clientes;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_almacen;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label12;
    }
}