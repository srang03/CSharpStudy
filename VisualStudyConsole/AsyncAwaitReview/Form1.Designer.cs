namespace AsyncAwaitReview
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_singleThread = new System.Windows.Forms.Button();
            this.btn_multiThread = new System.Windows.Forms.Button();
            this.btn_syncPrint = new System.Windows.Forms.Button();
            this.btn_asyncPrintSingle = new System.Windows.Forms.Button();
            this.btn_asyncPrintMulti = new System.Windows.Forms.Button();
            this.btn_asyncPrintMulti2 = new System.Windows.Forms.Button();
            this.lbl_Thread = new System.Windows.Forms.Label();
            this.list_thread = new System.Windows.Forms.ListBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_singleThread
            // 
            this.btn_singleThread.Location = new System.Drawing.Point(87, 189);
            this.btn_singleThread.Name = "btn_singleThread";
            this.btn_singleThread.Size = new System.Drawing.Size(143, 57);
            this.btn_singleThread.TabIndex = 0;
            this.btn_singleThread.Text = "SingleThread";
            this.btn_singleThread.UseVisualStyleBackColor = true;
            this.btn_singleThread.Click += new System.EventHandler(this.btn_singleThread_Click);
            // 
            // btn_multiThread
            // 
            this.btn_multiThread.Location = new System.Drawing.Point(278, 189);
            this.btn_multiThread.Name = "btn_multiThread";
            this.btn_multiThread.Size = new System.Drawing.Size(143, 57);
            this.btn_multiThread.TabIndex = 1;
            this.btn_multiThread.Text = "MultiThread";
            this.btn_multiThread.UseVisualStyleBackColor = true;
            this.btn_multiThread.Click += new System.EventHandler(this.btn_multiThread_Click);
            // 
            // btn_syncPrint
            // 
            this.btn_syncPrint.Location = new System.Drawing.Point(87, 276);
            this.btn_syncPrint.Name = "btn_syncPrint";
            this.btn_syncPrint.Size = new System.Drawing.Size(143, 57);
            this.btn_syncPrint.TabIndex = 1;
            this.btn_syncPrint.Text = "SyncPrint";
            this.btn_syncPrint.UseVisualStyleBackColor = true;
            this.btn_syncPrint.Click += new System.EventHandler(this.btn_syncPrint_Click);
            // 
            // btn_asyncPrintSingle
            // 
            this.btn_asyncPrintSingle.Location = new System.Drawing.Point(278, 276);
            this.btn_asyncPrintSingle.Name = "btn_asyncPrintSingle";
            this.btn_asyncPrintSingle.Size = new System.Drawing.Size(143, 57);
            this.btn_asyncPrintSingle.TabIndex = 1;
            this.btn_asyncPrintSingle.Text = "AsyncPrint (Single)";
            this.btn_asyncPrintSingle.UseVisualStyleBackColor = true;
            this.btn_asyncPrintSingle.Click += new System.EventHandler(this.btn_asyncPrintSingle_Click);
            // 
            // btn_asyncPrintMulti
            // 
            this.btn_asyncPrintMulti.Location = new System.Drawing.Point(87, 362);
            this.btn_asyncPrintMulti.Name = "btn_asyncPrintMulti";
            this.btn_asyncPrintMulti.Size = new System.Drawing.Size(143, 57);
            this.btn_asyncPrintMulti.TabIndex = 1;
            this.btn_asyncPrintMulti.Text = "AsyncPrint (Multi)";
            this.btn_asyncPrintMulti.UseVisualStyleBackColor = true;
            this.btn_asyncPrintMulti.Click += new System.EventHandler(this.btn_asyncPrintMulti_Click);
            // 
            // btn_asyncPrintMulti2
            // 
            this.btn_asyncPrintMulti2.Location = new System.Drawing.Point(278, 362);
            this.btn_asyncPrintMulti2.Name = "btn_asyncPrintMulti2";
            this.btn_asyncPrintMulti2.Size = new System.Drawing.Size(143, 57);
            this.btn_asyncPrintMulti2.TabIndex = 1;
            this.btn_asyncPrintMulti2.Text = "AsyncPrint (Multi) 2";
            this.btn_asyncPrintMulti2.UseVisualStyleBackColor = true;
            this.btn_asyncPrintMulti2.Click += new System.EventHandler(this.btn_asyncPrintMulti2_Click);
            // 
            // lbl_Thread
            // 
            this.lbl_Thread.AutoSize = true;
            this.lbl_Thread.Location = new System.Drawing.Point(85, 9);
            this.lbl_Thread.Name = "lbl_Thread";
            this.lbl_Thread.Size = new System.Drawing.Size(69, 12);
            this.lbl_Thread.TabIndex = 3;
            this.lbl_Thread.Text = "Thread List";
            // 
            // list_thread
            // 
            this.list_thread.FormattingEnabled = true;
            this.list_thread.ItemHeight = 12;
            this.list_thread.Location = new System.Drawing.Point(87, 59);
            this.list_thread.Name = "list_thread";
            this.list_thread.Size = new System.Drawing.Size(334, 112);
            this.list_thread.TabIndex = 4;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(85, 34);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 12);
            this.lbl_status.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 346);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.list_thread);
            this.Controls.Add(this.lbl_Thread);
            this.Controls.Add(this.btn_asyncPrintMulti2);
            this.Controls.Add(this.btn_asyncPrintMulti);
            this.Controls.Add(this.btn_asyncPrintSingle);
            this.Controls.Add(this.btn_syncPrint);
            this.Controls.Add(this.btn_multiThread);
            this.Controls.Add(this.btn_singleThread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_singleThread;
        private System.Windows.Forms.Button btn_multiThread;
        private System.Windows.Forms.Button btn_syncPrint;
        private System.Windows.Forms.Button btn_asyncPrintSingle;
        private System.Windows.Forms.Button btn_asyncPrintMulti;
        private System.Windows.Forms.Button btn_asyncPrintMulti2;
        private System.Windows.Forms.Label lbl_Thread;
        private System.Windows.Forms.ListBox list_thread;
        private System.Windows.Forms.Label lbl_status;
    }
}

