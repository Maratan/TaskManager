namespace TaskManager
{
    partial class FormMain
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
            this.g_TaskList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Executor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.профильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_TaskCreate = new System.Windows.Forms.Button();
            this.b_TaskEdit = new System.Windows.Forms.Button();
            this.b_TaskDel = new System.Windows.Forms.Button();
            this.b_TaskFilter = new System.Windows.Forms.Button();
            this.b_TaskUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.g_TaskList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // g_TaskList
            // 
            this.g_TaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.g_TaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Task,
            this.Executor,
            this.Priority});
            this.g_TaskList.Location = new System.Drawing.Point(12, 57);
            this.g_TaskList.Name = "g_TaskList";
            this.g_TaskList.Size = new System.Drawing.Size(810, 407);
            this.g_TaskList.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Идентификатор";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Task
            // 
            this.Task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Task.HeaderText = "Задача";
            this.Task.Name = "Task";
            // 
            // Executor
            // 
            this.Executor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Executor.HeaderText = "Исполнитель";
            this.Executor.Name = "Executor";
            // 
            // Priority
            // 
            this.Priority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Priority.HeaderText = "Приоритет";
            this.Priority.Name = "Priority";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.администрированиеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.профильToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // профильToolStripMenuItem
            // 
            this.профильToolStripMenuItem.Name = "профильToolStripMenuItem";
            this.профильToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.профильToolStripMenuItem.Text = "Профиль";
            this.профильToolStripMenuItem.Click += new System.EventHandler(this.профильToolStripMenuItem_Click);
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            this.администрированиеToolStripMenuItem.Click += new System.EventHandler(this.администрированиеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // b_TaskCreate
            // 
            this.b_TaskCreate.Location = new System.Drawing.Point(13, 28);
            this.b_TaskCreate.Name = "b_TaskCreate";
            this.b_TaskCreate.Size = new System.Drawing.Size(99, 23);
            this.b_TaskCreate.TabIndex = 2;
            this.b_TaskCreate.Text = "Создать";
            this.b_TaskCreate.UseVisualStyleBackColor = true;
            this.b_TaskCreate.Click += new System.EventHandler(this.b_TaskCreate_Click);
            // 
            // b_TaskEdit
            // 
            this.b_TaskEdit.Location = new System.Drawing.Point(118, 28);
            this.b_TaskEdit.Name = "b_TaskEdit";
            this.b_TaskEdit.Size = new System.Drawing.Size(99, 23);
            this.b_TaskEdit.TabIndex = 3;
            this.b_TaskEdit.Text = "Редактировать";
            this.b_TaskEdit.UseVisualStyleBackColor = true;
            this.b_TaskEdit.Click += new System.EventHandler(this.b_TaskEdit_Click);
            // 
            // b_TaskDel
            // 
            this.b_TaskDel.Location = new System.Drawing.Point(223, 28);
            this.b_TaskDel.Name = "b_TaskDel";
            this.b_TaskDel.Size = new System.Drawing.Size(100, 23);
            this.b_TaskDel.TabIndex = 4;
            this.b_TaskDel.Text = "Удалить";
            this.b_TaskDel.UseVisualStyleBackColor = true;
            // 
            // b_TaskFilter
            // 
            this.b_TaskFilter.Location = new System.Drawing.Point(666, 28);
            this.b_TaskFilter.Name = "b_TaskFilter";
            this.b_TaskFilter.Size = new System.Drawing.Size(75, 23);
            this.b_TaskFilter.TabIndex = 5;
            this.b_TaskFilter.Text = "Фильтр";
            this.b_TaskFilter.UseVisualStyleBackColor = true;
            this.b_TaskFilter.Click += new System.EventHandler(this.b_TaskFilter_Click);
            // 
            // b_TaskUpdate
            // 
            this.b_TaskUpdate.Location = new System.Drawing.Point(747, 28);
            this.b_TaskUpdate.Name = "b_TaskUpdate";
            this.b_TaskUpdate.Size = new System.Drawing.Size(75, 23);
            this.b_TaskUpdate.TabIndex = 6;
            this.b_TaskUpdate.Text = "Обновить";
            this.b_TaskUpdate.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(834, 476);
            this.Controls.Add(this.b_TaskUpdate);
            this.Controls.Add(this.b_TaskFilter);
            this.Controls.Add(this.b_TaskDel);
            this.Controls.Add(this.b_TaskEdit);
            this.Controls.Add(this.b_TaskCreate);
            this.Controls.Add(this.g_TaskList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер задач";
            ((System.ComponentModel.ISupportInitialize)(this.g_TaskList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView g_TaskList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button b_TaskCreate;
        private System.Windows.Forms.Button b_TaskEdit;
        private System.Windows.Forms.Button b_TaskDel;
        private System.Windows.Forms.Button b_TaskFilter;
        private System.Windows.Forms.Button b_TaskUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Executor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem профильToolStripMenuItem;
    }
}

