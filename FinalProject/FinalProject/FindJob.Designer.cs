namespace FinalProject
{
    partial class FindJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindJob));
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.CBAddress = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TbFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flowLayoutjobs = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateCV = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Tools = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Blogs = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.CreateCV.SuspendLayout();
            this.Tools.SuspendLayout();
            this.Blogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.CreateCV);
            this.guna2TabControl1.Controls.Add(this.Tools);
            this.guna2TabControl1.Controls.Add(this.Blogs);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1148, 631);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabButtonTextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.guna2TabControl1.TabIndex = 8;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.flowLayoutjobs);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jobs";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.guna2CirclePictureBox2);
            this.panel2.Controls.Add(this.CBAddress);
            this.panel2.Controls.Add(this.TbFind);
            this.panel2.Controls.Add(this.guna2PictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 50);
            this.panel2.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(724, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 35);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(577, 5);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(37, 35);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 12;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.Click += new System.EventHandler(this.guna2CirclePictureBox2_Click);
            // 
            // CBAddress
            // 
            this.CBAddress.BackColor = System.Drawing.Color.Transparent;
            this.CBAddress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAddress.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBAddress.ItemHeight = 30;
            this.CBAddress.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau ",
            "Cao Bằng",
            "Cần Thơ",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hòa Bình",
            "Hồ Chí Minh",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "TP Hồ Chí Minh",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc"});
            this.CBAddress.Location = new System.Drawing.Point(324, 6);
            this.CBAddress.Name = "CBAddress";
            this.CBAddress.Size = new System.Drawing.Size(219, 36);
            this.CBAddress.TabIndex = 0;
            // 
            // TbFind
            // 
            this.TbFind.AutoCompleteCustomSource.AddRange(new string[] {
            "Web Developer",
            "Warehouse Manager",
            "Welder",
            "Writer",
            "Waiter/Waitress",
            "Warehouse Worker",
            "Web Designer",
            "Welding Inspector",
            "Wildlife Biologist",
            "Wind Turbine Technician",
            "Quality Assurance Engineer",
            "Quality Control Inspector",
            "Quantity Surveyor",
            "Quantitative Analyst",
            "Quality Manager",
            "Quality Control Technician",
            "Quarry Manager",
            "Quantitative Research Analyst",
            "Quantitative Trader",
            "Quality Assurance Analyst",
            "Engineer",
            "Entrepreneur",
            "Educator",
            "Environmentalist",
            "Economist",
            "Electrician",
            "Event planner",
            "Executive",
            "Explorer",
            "Editorial assistant",
            "Education consultant",
            "Environmental engineer",
            "Electrical engineer",
            "Event coordinator",
            "Executive assistant",
            "Engineer",
            "Entrepreneur",
            "Educator",
            "Environmentalist",
            "Economist",
            "Electrician",
            "Event planner",
            "Executive",
            "Explorer",
            "Editorial assistant",
            "Education consultant",
            "Environmental engineer",
            "Electrical engineer",
            "Event coordinator",
            "Executive assistant",
            "Kỹ sư",
            "Doanh nhân",
            "Giáo viên",
            "Chuyên gia môi trường",
            "Nhà kinh tế học",
            "Thợ điện",
            "Người lập kế hoạch sự kiện",
            "Giám đốc điều hành",
            "Khám phá viên",
            "Trợ lý biên tập",
            "Chuyên gia tư vấn giáo dục",
            "Kỹ sư môi trường",
            "Kỹ sư điện",
            "Điều phối viên sự kiện",
            "Trợ lý giám đốc",
            "Research scientist",
            "Reporter",
            "Retail associate",
            "Real estate agent",
            "Registered nurse",
            "Restaurant manager",
            "Receptionist",
            "Recruiter",
            "Rigger",
            "Robotics engineer",
            "Nhà khoa học nghiên cứu",
            "Phóng viên",
            "Nhân viên bán lẻ",
            "Môi giới bất động sản",
            "Điều dưỡng viên",
            "Quản lý nhà hàng",
            "Lễ tân",
            "Tuyển dụng viên",
            "Thợ giàn khoan",
            "Kỹ sư robot ",
            "Teacher",
            "Translator",
            "Truck driver",
            "Technician",
            "Therapist",
            "Travel agent",
            "Team leader",
            "Telemarketer",
            "Tailor",
            "Tax accountant",
            "Giáo viên",
            "Dịch giả",
            "Tài xế xe tải",
            "Kỹ thuật viên",
            "Chuyên viên trị liệu",
            "Đại lý du lịch",
            "Trưởng nhóm",
            "Nhân viên tiếp thị qua điện thoại",
            "Thợ may",
            "Kế toán thuế",
            "Yoga instructor",
            "Youth worker",
            "Giáo viên yoga",
            "Nhân viên công tác thanh thiếu niên",
            "Urban planner",
            "Underwriter",
            "User experience designer",
            "University professor",
            "Ultrasound technician",
            "Quy hoạch đô thị",
            "Chuyên viên bảo hiểm",
            "Thiết kế trải nghiệm người dùng",
            "Giảng viên đại học",
            "Kỹ thuật viên siêu âm",
            "Illustrator",
            "Interpreter",
            "Inspector",
            "Insurance agent",
            "Interior designer",
            "Investment banker",
            "IT specialist",
            "Industrial engineer",
            "Information security analyst",
            "International business manager",
            "Họa sĩ minh họa",
            "Phiên dịch viên",
            "Thanh tra viên",
            "Đại lý bảo hiểm",
            "Kiến trúc sư nội thất",
            "Chuyên viên ngân hàng đầu tư",
            "Chuyên viên CNTT",
            "Kỹ sư công nghiệp",
            "Chuyên viên phân tích an ninh thông tin",
            "Quản lý kinh doanh quốc tế",
            "Occupational therapist",
            "Ophthalmologist",
            "Optometrist",
            "Orthodontist",
            "Osteopath",
            "Otolaryngologist",
            "Outpatient nurse",
            "Office manager",
            "Operations manager",
            "Orderly",
            "Chuyên viên trị liệu nghề nghiệp",
            "Bác sĩ nhãn khoa",
            "Bác sĩ đo thị lực",
            "Bác sĩ chỉnh nha",
            "Bác sĩ nắn xương",
            "Bác sĩ tai mũi họng",
            "Y tá ngoại trú",
            "Quản lý văn phòng",
            "Quản lý vận hành",
            "Nhân viên phục vụ y tế",
            "Pilot",
            "Pharmacist",
            "Professor",
            "Photographer",
            "Programmer",
            "Plumber",
            "Police officer",
            "Phi công",
            "Dược sĩ",
            "Giáo sư",
            "Nhiếp ảnh gia",
            "Lập trình viên",
            "Thợ sửa ống nước",
            "Cảnh sát viên",
            "Actor",
            "Accountant",
            "Artist",
            "Architect",
            "Attorney",
            "Administrator",
            "Analyst",
            "Diễn viên",
            "Kế toán viên",
            "Nghệ sĩ",
            "Kiến trúc sư",
            "Luật sư",
            "Quản trị viên",
            "Nhà phân tích",
            "Scientist",
            "Salesperson",
            "Secretary",
            "Security guard",
            "Singer",
            "Software developer",
            "Surgeon",
            "Farmer",
            "Firefighter",
            "Nông dân",
            "Lính cứu hỏa",
            "Gardener",
            "Graphic designer",
            "Geologist",
            "Geneticist",
            "Game developer",
            "Guitarist",
            "Geographer",
            "Gynecologist",
            "Garbage collector",
            "Gardening assistant",
            "Người làm vườn",
            "Nhà thiết kế đồ họa",
            "Nhà địa chất học",
            "Nhà di truyền học",
            "Nhà phát triển trò chơi",
            "Nghệ sĩ guitar",
            "Nhà địa lý học",
            "Bác sĩ phụ khoa",
            "Người thu gom rác",
            "Trợ lý làm vườn",
            "Historian",
            "Hairdresser",
            "Herbalist",
            "Housekeeper",
            "Handyman",
            "Horticulturist",
            "Health inspector",
            "Historiographer",
            "Homeopath",
            "Human resources manager",
            "Sử gia",
            "Thợ làm tóc",
            "Người sử dụng các loại thảo dược",
            "Nhân viên nhà hàng",
            "Thợ sửa chữa đa năng",
            "Nhà nông học",
            "Thanh tra y tế",
            "Sử học gia",
            "Bác sĩ dược học",
            "Quản lý nguồn nhân lực",
            "Judge (Thẩm phán)",
            "Journalist (Nhà báo)\t",
            "Thẩm phán",
            "Nhà báo",
            "Karate instructor",
            "Kindergarten teacher",
            "Kitchen manager",
            "Kennel attendant",
            "Keyboardist",
            "Kinesiologist",
            "Kickstarter campaign manager",
            "Knife maker",
            "Knitwear designer",
            "Karaoke host",
            "Huấn luyện viên Karate",
            "Giáo viên mầm non",
            "Quản lý nhà bếp",
            "Nhân viên chó mèo",
            "Người chơi đàn keyboard",
            "Nhà hình thể học",
            "Quản lý chiến dịch Kickstarter",
            "Thợ làm dao",
            "Nhà thiết kế đồ len",
            "Người dẫn chương trình karaoke",
            "Luật sư",
            "Thủ thư",
            "Giảng viên",
            "Nhà thiết kế cảnh quan",
            "Người cứu hộ",
            "Ngôn ngữ học gia",
            "Kỹ thuật viên phòng thí nghiệm",
            "Nhân viên cho vay",
            "Quản lý vận tải",
            "Người giữ hải đăng",
            "Lawyer",
            "Librarian",
            "Lecturer",
            "Landscaper",
            "Lifeguard",
            "Linguist",
            "Lab technician",
            "Loan officer",
            "Logistics manager",
            "Lighthouse keeper",
            "Zoologist ",
            "Nhà động vật học",
            "Zookeeper  ",
            "Người chăm sóc động vật trong vườn thú",
            "Zookeeper",
            "Zoologist",
            "Zip line guide",
            "Zen therapist",
            "Zumba instructor",
            "Zither player",
            "Zine publisher",
            "Zamboni driver",
            "Zirconia technician",
            "Zigzag stitcher",
            "Người chăm sóc vườn thú",
            "Nhà động vật học",
            "Hướng dẫn dây trượt",
            "Thợ trị liệu Zen",
            "Hướng dẫn Zumba",
            "Người chơi đàn zither",
            "Nhà xuất bản tạp chí nhỏ",
            "Tài xế máy chà băng Zamboni",
            "Kỹ thuật viên zirconia",
            "Thợ may kiểu zigzag",
            "X-ray technician",
            "Xenobiologist",
            "Xylophonist",
            "Xeriscaping specialist",
            "X-ray inspector",
            "Xerox operator",
            "X-ray engineer",
            "X-ray physicist",
            "X-ray analyst",
            "X-ray equipment installer",
            "Kỹ thuật viên chụp X-quang",
            "Nhà sinh vật học ngoài hành tinh",
            "Người chơi xylophone",
            "Chuyên viên thiết kế cảnh quan xeriscaping",
            "Thợ kiểm tra chụp X-quang",
            "Nhân viên máy photocopy",
            "Kỹ sư chụp X-quang",
            "Nhà vật lý chụp X-quang",
            "Nhà phân tích chụp X-quang",
            "Thợ lắp đặt thiết bị chụp X-quang",
            "Carpenter",
            "Chef",
            "Counselor",
            "Chemist",
            "CEO (Chief Executive Officer)",
            "Customer service representative",
            "Choreographer",
            "Civil engineer",
            "Curator",
            "Copywriter",
            "Thợ mộc",
            "Đầu bếp",
            "Tư vấn viên",
            "Nhà hóa học",
            "Giám đốc điều hành",
            "Nhân viên dịch vụ khách hàng",
            "Biên đạo múa",
            "Kỹ sư xây dựng",
            "Người quản lý bảo tàng",
            "Biên tập viên văn bản",
            "Veterinarian",
            "Vocal coach",
            "Video editor",
            "Virtual assistant",
            "Violinist",
            "Virologist",
            "Vice president",
            "Visual artist",
            "Volleyball coach",
            "Valet parking attendant",
            "Bác sĩ thú y",
            "Huấn luyện viên hát",
            "Biên tập viên video",
            "Trợ lý ảo",
            "Nghệ sĩ violin",
            "Nhà nghiên cứu virus",
            "Phó chủ tịch",
            "Nghệ sĩ hình ảnh",
            "Huấn luyện viên bóng chuyền",
            "Người phục vụ đậu xe",
            "Baker",
            "Banker",
            "Biologist",
            "Barber",
            "Business analyst",
            "Bartender",
            "Bookkeeper",
            "Botanist",
            "Butcher",
            "Bus driver",
            "Thợ làm bánh",
            "Ngân hàng viên",
            "Nhà sinh vật học",
            "Thợ cắt tóc",
            "Phân tích kinh doanh",
            "Bartender",
            "Kế toán viên",
            "Nhà thực vật học",
            "Thợ mổ",
            "Tài xế xe buýt",
            "Nurse",
            "Novelist",
            "Neurologist",
            "Nutritionist",
            "News anchor",
            "Network administrator",
            "Nuclear physicist",
            "Numerical analyst",
            "Nanny",
            "Naval architect",
            "Y tá",
            "Nhà văn",
            "Bác sĩ thần kinh học",
            "Chuyên gia dinh dưỡng",
            "Phóng viên tin tức",
            "Quản trị mạng",
            "Nhà vật lý hạt nhân",
            "Nhà phân tích số",
            "Người giữ trẻ",
            "Kiến trúc sư hải quân",
            "Mechanic",
            "Mathematician",
            "Musician",
            "Marketing manager",
            "Meteorologist",
            "Medical doctor",
            "Marine biologist",
            "Makeup artist",
            "Machine operator",
            "Magician",
            "Thợ cơ khí",
            "Nhà toán học",
            "Nhạc sĩ",
            "Quản lý marketing",
            "Nhà dự báo thời tiết",
            "Bác sĩ",
            "Nhà sinh vật học biển",
            "Nhà làm đẹp",
            "Người vận hành máy móc",
            "Ảo thuật gia"});
            this.TbFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TbFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TbFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbFind.DefaultText = "";
            this.TbFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbFind.Location = new System.Drawing.Point(15, 6);
            this.TbFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbFind.Name = "TbFind";
            this.TbFind.PasswordChar = '\0';
            this.TbFind.PlaceholderText = "";
            this.TbFind.SelectedText = "";
            this.TbFind.Size = new System.Drawing.Size(288, 37);
            this.TbFind.TabIndex = 11;
            this.TbFind.TextChanged += new System.EventHandler(this.TbFind_TextChanged);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(910, 6);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(39, 35);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 10;
            this.guna2PictureBox2.TabStop = false;
            // 
            // flowLayoutjobs
            // 
            this.flowLayoutjobs.AutoScroll = true;
            this.flowLayoutjobs.Location = new System.Drawing.Point(3, 51);
            this.flowLayoutjobs.Name = "flowLayoutjobs";
            this.flowLayoutjobs.Size = new System.Drawing.Size(954, 569);
            this.flowLayoutjobs.TabIndex = 0;
            this.flowLayoutjobs.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutjobs_Paint);
            // 
            // CreateCV
            // 
            this.CreateCV.Controls.Add(this.flowLayoutPanel1);
            this.CreateCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCV.Location = new System.Drawing.Point(184, 4);
            this.CreateCV.Name = "CreateCV";
            this.CreateCV.Padding = new System.Windows.Forms.Padding(3);
            this.CreateCV.Size = new System.Drawing.Size(960, 623);
            this.CreateCV.TabIndex = 1;
            this.CreateCV.Text = "Create CV";
            this.CreateCV.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(954, 617);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Tools
            // 
            this.Tools.Controls.Add(this.flowLayoutPanel2);
            this.Tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tools.Location = new System.Drawing.Point(184, 4);
            this.Tools.Name = "Tools";
            this.Tools.Padding = new System.Windows.Forms.Padding(3);
            this.Tools.Size = new System.Drawing.Size(960, 623);
            this.Tools.TabIndex = 2;
            this.Tools.Text = "Tools";
            this.Tools.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(954, 617);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // Blogs
            // 
            this.Blogs.Controls.Add(this.flowLayoutPanel3);
            this.Blogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blogs.Location = new System.Drawing.Point(184, 4);
            this.Blogs.Name = "Blogs";
            this.Blogs.Padding = new System.Windows.Forms.Padding(3);
            this.Blogs.Size = new System.Drawing.Size(960, 623);
            this.Blogs.TabIndex = 3;
            this.Blogs.Text = "Blogs";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(954, 617);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // FindJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 631);
            this.Controls.Add(this.guna2TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FindJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindJob";
            this.Load += new System.EventHandler(this.FindJob_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.CreateCV.ResumeLayout(false);
            this.Tools.ResumeLayout(false);
            this.Blogs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage CreateCV;
        public System.Windows.Forms.TabPage Tools;
        public System.Windows.Forms.TabPage Blogs;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutjobs;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        public System.Windows.Forms.Panel panel2;
        public Guna.UI2.WinForms.Guna2TextBox TbFind;
        public Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        public Guna.UI2.WinForms.Guna2ComboBox CBAddress;
        private Guna.UI2.WinForms.Guna2Button btnReset;
    }
}