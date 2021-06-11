
namespace WindowsFormsApp12
{
    partial class Sims4
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sims4));
            this.lvPersonages = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.pInfo = new System.Windows.Forms.Panel();
            this.nature = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lifeGoal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.finance = new System.Windows.Forms.NumericUpDown();
            this.familyStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnSrialize = new System.Windows.Forms.Button();
            this.pInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finance)).BeginInit();
            this.SuspendLayout();
            // 
            // lvPersonages
            // 
            this.lvPersonages.HideSelection = false;
            this.lvPersonages.Location = new System.Drawing.Point(47, 62);
            this.lvPersonages.Name = "lvPersonages";
            this.lvPersonages.Size = new System.Drawing.Size(199, 397);
            this.lvPersonages.TabIndex = 0;
            this.lvPersonages.UseCompatibleStateImageBehavior = false;
            this.lvPersonages.View = System.Windows.Forms.View.List;
            this.lvPersonages.SelectedIndexChanged += new System.EventHandler(this.lvUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERSONAGES";
            // 
            // pInfo
            // 
            this.pInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pInfo.Controls.Add(this.nature);
            this.pInfo.Controls.Add(this.label11);
            this.pInfo.Controls.Add(this.city);
            this.pInfo.Controls.Add(this.label10);
            this.pInfo.Controls.Add(this.id);
            this.pInfo.Controls.Add(this.label9);
            this.pInfo.Controls.Add(this.lifeGoal);
            this.pInfo.Controls.Add(this.label8);
            this.pInfo.Controls.Add(this.age);
            this.pInfo.Controls.Add(this.label7);
            this.pInfo.Controls.Add(this.label2);
            this.pInfo.Controls.Add(this.label6);
            this.pInfo.Controls.Add(this.btnAdd);
            this.pInfo.Controls.Add(this.finance);
            this.pInfo.Controls.Add(this.familyStatus);
            this.pInfo.Controls.Add(this.label5);
            this.pInfo.Controls.Add(this.name);
            this.pInfo.Controls.Add(this.label3);
            this.pInfo.Location = new System.Drawing.Point(327, 62);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(215, 368);
            this.pInfo.TabIndex = 2;
            // 
            // nature
            // 
            this.nature.FormattingEnabled = true;
            this.nature.Items.AddRange(new object[] {
            "Human",
            "Vampire",
            "Mermaid",
            "Enchantress"});
            this.nature.Location = new System.Drawing.Point(21, 306);
            this.nature.Name = "nature";
            this.nature.Size = new System.Drawing.Size(174, 21);
            this.nature.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Nature";
            // 
            // city
            // 
            this.city.FormattingEnabled = true;
            this.city.Items.AddRange(new object[] {
            "Willow Creek",
            "Oasis Springs",
            "Newcrest",
            "Magnolia Promenade",
            "Vinderburg",
            "San Mishuno",
            "Forgotn Hollow",
            "Brindleton Bay",
            "Del Sol Valley",
            "Strangerville",
            "Sulani",
            "Glimmerburg"});
            this.city.Location = new System.Drawing.Point(21, 266);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(174, 21);
            this.city.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "City";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(24, 30);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(174, 20);
            this.id.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "id";
            // 
            // lifeGoal
            // 
            this.lifeGoal.Location = new System.Drawing.Point(21, 227);
            this.lifeGoal.Name = "lifeGoal";
            this.lifeGoal.Size = new System.Drawing.Size(174, 20);
            this.lifeGoal.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Life Goal";
            // 
            // age
            // 
            this.age.FormattingEnabled = true;
            this.age.Items.AddRange(new object[] {
            "young",
            "adult",
            "elderly"});
            this.age.Location = new System.Drawing.Point(21, 108);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(174, 21);
            this.age.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Finance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Age";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(123, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // finance
            // 
            this.finance.Location = new System.Drawing.Point(21, 188);
            this.finance.Name = "finance";
            this.finance.Size = new System.Drawing.Size(174, 20);
            this.finance.TabIndex = 6;
            // 
            // familyStatus
            // 
            this.familyStatus.FormattingEnabled = true;
            this.familyStatus.Items.AddRange(new object[] {
            "married",
            "not married"});
            this.familyStatus.Location = new System.Drawing.Point(21, 148);
            this.familyStatus.Name = "familyStatus";
            this.familyStatus.Size = new System.Drawing.Size(174, 21);
            this.familyStatus.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Family Status";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(21, 69);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(174, 20);
            this.name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(377, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "INFORMATION";
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeserialize.Location = new System.Drawing.Point(327, 436);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(75, 23);
            this.btnDeserialize.TabIndex = 9;
            this.btnDeserialize.Text = "desirializate";
            this.btnDeserialize.UseVisualStyleBackColor = false;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnSrialize
            // 
            this.btnSrialize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSrialize.Location = new System.Drawing.Point(467, 436);
            this.btnSrialize.Name = "btnSrialize";
            this.btnSrialize.Size = new System.Drawing.Size(75, 23);
            this.btnSrialize.TabIndex = 10;
            this.btnSrialize.Text = "serializate";
            this.btnSrialize.UseVisualStyleBackColor = false;
            this.btnSrialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // Sims4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(593, 494);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSrialize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvPersonages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sims4";
            this.Text = "Sims 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPersonages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown finance;
        private System.Windows.Forms.ComboBox familyStatus;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Button btnSrialize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lifeGoal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox age;
        private System.Windows.Forms.ComboBox nature;
        private System.Windows.Forms.Label label11;
    }
}

