using Microsoft.EntityFrameworkCore;
using System.Data;

namespace AdminUI.Date.Models
{
    public partial class NFineDBContext : DbContext
    {
        public NFineDBContext()
        {
        }

        public NFineDBContext(DbContextOptions<NFineDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sys_Area> Sys_Area { get; set; }
        public virtual DbSet<Sys_DbBackup> Sys_DbBackup { get; set; }
        public virtual DbSet<Sys_FilterIP> Sys_FilterIP { get; set; }
        public virtual DbSet<Sys_Items> Sys_Items { get; set; }
        public virtual DbSet<Sys_ItemsDetail> Sys_ItemsDetail { get; set; }
        public virtual DbSet<Sys_Log> Sys_Log { get; set; }
        public virtual DbSet<Sys_Module> Sys_Module { get; set; }
        public virtual DbSet<Sys_ModuleButton> Sys_ModuleButton { get; set; }
        public virtual DbSet<Sys_ModuleForm> Sys_ModuleForm { get; set; }
        public virtual DbSet<Sys_ModuleFormInstance> Sys_ModuleFormInstance { get; set; }
        public virtual DbSet<Sys_Organize> Sys_Organize { get; set; }
        public virtual DbSet<Sys_Role> Sys_Role { get; set; }
        public virtual DbSet<Sys_RoleAuthorize> Sys_RoleAuthorize { get; set; }
        public virtual DbSet<Sys_User> Sys_User { get; set; }
        public virtual DbSet<Sys_UserLogOn> Sys_UserLogOn { get; set; }


        public virtual DbSet<mstb_monitorhistory> mstb_monitorhistory { get; set; }
        public virtual DbSet<mstb_monitorcurrent> mstb_monitorcurrent { get; set; }
        public virtual DbSet<mstb_monitorstate> mstb_monitorstate { get; set; }
       


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<mstb_monitorhistory>(entity => {
                entity.HasKey(e=>e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<mstb_monitorcurrent>(entity => {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<mstb_monitorstate>(entity => {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Sys_Area>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_AREA")
                    .IsClustered(false);

                entity.HasComment("行政区域表");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("主键");

                entity.Property(e => e.F_CreatorTime)
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.F_CreatorUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户主键");

                entity.Property(e => e.F_DeleteMark).HasComment("删除标志");

                entity.Property(e => e.F_DeleteTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.F_DeleteUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("删除用户");

                entity.Property(e => e.F_Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.F_EnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("编码");

                entity.Property(e => e.F_EnabledMark).HasComment("有效标志");

                entity.Property(e => e.F_FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.F_LastModifyTime)
                    .HasColumnType("datetime")
                    .HasComment("最后修改时间");

                entity.Property(e => e.F_LastModifyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后修改用户");

                entity.Property(e => e.F_Layers).HasComment("层次");

                entity.Property(e => e.F_ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("父级");

                entity.Property(e => e.F_SimpleSpelling)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("简拼");

                entity.Property(e => e.F_SortCode).HasComment("排序码");
            });

            modelBuilder.Entity<Sys_DbBackup>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_DBBACKUP")
                    .IsClustered(false);

                entity.HasComment("数据库备份");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("备份主键");

                entity.Property(e => e.F_BackupTime)
                    .HasColumnType("datetime")
                    .HasComment("备份时间");

                entity.Property(e => e.F_BackupType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("备份类型");

                entity.Property(e => e.F_CreatorTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.F_CreatorUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户");

                entity.Property(e => e.F_DbName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("数据库名称");

                entity.Property(e => e.F_DeleteMark).HasComment("删除标志");

                entity.Property(e => e.F_DeleteTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.F_DeleteUserId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("删除用户");

                entity.Property(e => e.F_Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.F_EnabledMark).HasComment("有效标志");

                entity.Property(e => e.F_FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("文件名称");

                entity.Property(e => e.F_FilePath)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("文件路径");

                entity.Property(e => e.F_FileSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("文件大小");

                entity.Property(e => e.F_LastModifyTime)
                    .HasColumnType("datetime")
                    .HasComment("最后修改时间");

                entity.Property(e => e.F_LastModifyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后修改用户");

                entity.Property(e => e.F_SortCode).HasComment("排序码");
            });

            modelBuilder.Entity<Sys_FilterIP>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_FILTERIP")
                    .IsClustered(false);

                entity.HasComment("过滤IP");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("过滤主键");

                entity.Property(e => e.F_CreatorTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.F_CreatorUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户");

                entity.Property(e => e.F_DeleteMark).HasComment("删除标志");

                entity.Property(e => e.F_DeleteTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.F_DeleteUserId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("删除用户");

                entity.Property(e => e.F_Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.F_EnabledMark).HasComment("有效标志");

                entity.Property(e => e.F_EndIP)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("结束IP");

                entity.Property(e => e.F_LastModifyTime)
                    .HasColumnType("datetime")
                    .HasComment("最后修改时间");

                entity.Property(e => e.F_LastModifyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后修改用户");

                entity.Property(e => e.F_SortCode).HasComment("排序码");

                entity.Property(e => e.F_StartIP)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("开始IP");

                entity.Property(e => e.F_Type).HasComment("类型");
            });

            modelBuilder.Entity<Sys_Items>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_ITEMS")
                    .IsClustered(false);

                entity.HasComment("选项主表");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("主表主键");

                entity.Property(e => e.F_CreatorTime)
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.F_CreatorUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户主键");

                entity.Property(e => e.F_DeleteMark).HasComment("删除标志");

                entity.Property(e => e.F_DeleteTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.F_DeleteUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("删除用户");

                entity.Property(e => e.F_Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.F_EnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("编码");

                entity.Property(e => e.F_EnabledMark).HasComment("有效标志");

                entity.Property(e => e.F_FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.F_IsTree).HasComment("树型");

                entity.Property(e => e.F_LastModifyTime)
                    .HasColumnType("datetime")
                    .HasComment("最后修改时间");

                entity.Property(e => e.F_LastModifyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后修改用户");

                entity.Property(e => e.F_Layers).HasComment("层次");

                entity.Property(e => e.F_ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("父级");

                entity.Property(e => e.F_SortCode).HasComment("排序码");
            });

            modelBuilder.Entity<Sys_ItemsDetail>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_ITEMDETAIL")
                    .IsClustered(false);

                entity.HasComment("选项明细表");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("明细主键");

                entity.Property(e => e.F_CreatorTime)
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.F_CreatorUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户主键");

                entity.Property(e => e.F_DeleteMark).HasComment("删除标志");

                entity.Property(e => e.F_DeleteTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.F_DeleteUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("删除用户");

                entity.Property(e => e.F_Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.F_EnabledMark).HasComment("有效标志");

                entity.Property(e => e.F_IsDefault).HasComment("默认");

                entity.Property(e => e.F_ItemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("编码");

                entity.Property(e => e.F_ItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("主表主键");

                entity.Property(e => e.F_ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.F_LastModifyTime)
                    .HasColumnType("datetime")
                    .HasComment("最后修改时间");

                entity.Property(e => e.F_LastModifyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后修改用户");

                entity.Property(e => e.F_Layers).HasComment("层次");

                entity.Property(e => e.F_ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("父级");

                entity.Property(e => e.F_SimpleSpelling)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("简拼");

                entity.Property(e => e.F_SortCode).HasComment("排序码");
            });

            modelBuilder.Entity<Sys_Log>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_LOG")
                    .IsClustered(false);

                entity.HasComment("系统日志");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("日志主键");

                entity.Property(e => e.F_Account)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("用户名");

                entity.Property(e => e.F_CreatorTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.F_CreatorUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户");

                entity.Property(e => e.F_Date)
                    .HasColumnType("datetime")
                    .HasComment("日期");

                entity.Property(e => e.F_Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.F_IPAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("IP地址");

                entity.Property(e => e.F_IPAddressName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("IP所在城市");

                entity.Property(e => e.F_ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("系统模块Id");

                entity.Property(e => e.F_ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("系统模块");

                entity.Property(e => e.F_NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("姓名");

                entity.Property(e => e.F_Result).HasComment("结果");

                entity.Property(e => e.F_Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("类型");
            });

            modelBuilder.Entity<Sys_Module>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_MODULE")
                    .IsClustered(false);

                entity.HasComment("系统模块");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("模块主键");

                entity.Property(e => e.F_AllowDelete).HasComment("允许删除");

                entity.Property(e => e.F_AllowEdit).HasComment("允许编辑");

                entity.Property(e => e.F_CreatorTime)
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.F_CreatorUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户主键");

                entity.Property(e => e.F_DeleteMark).HasComment("删除标志");

                entity.Property(e => e.F_DeleteTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.F_DeleteUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("删除用户");

                entity.Property(e => e.F_Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.F_EnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("编码");

                entity.Property(e => e.F_EnabledMark).HasComment("有效标志");

                entity.Property(e => e.F_FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.F_Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("图标");

                entity.Property(e => e.F_IsExpand).HasComment("展开");

                entity.Property(e => e.F_IsMenu).HasComment("菜单");

                entity.Property(e => e.F_IsPublic).HasComment("公共");

                entity.Property(e => e.F_LastModifyTime)
                    .HasColumnType("datetime")
                    .HasComment("最后修改时间");

                entity.Property(e => e.F_LastModifyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后修改用户");

                entity.Property(e => e.F_Layers).HasComment("层次");

                entity.Property(e => e.F_ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("父级");

                entity.Property(e => e.F_SortCode).HasComment("排序码");

                entity.Property(e => e.F_Target)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("目标");

                entity.Property(e => e.F_UrlAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("连接");
            });

            modelBuilder.Entity<Sys_ModuleButton>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_MODULEBUTTON")
                    .IsClustered(false);

                entity.HasComment("模块按钮");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("按钮主键");

                entity.Property(e => e.F_AllowDelete).HasComment("允许删除");

                entity.Property(e => e.F_AllowEdit).HasComment("允许编辑");

                entity.Property(e => e.F_CreatorTime)
                    .HasColumnType("datetime")
                    .HasComment("创建日期");

                entity.Property(e => e.F_CreatorUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户主键");

                entity.Property(e => e.F_DeleteMark).HasComment("删除标志");

                entity.Property(e => e.F_DeleteTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.F_DeleteUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("删除用户");

                entity.Property(e => e.F_Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.F_EnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("编码");

                entity.Property(e => e.F_EnabledMark).HasComment("有效标志");

                entity.Property(e => e.F_FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.F_Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("图标");

                entity.Property(e => e.F_IsPublic).HasComment("公共");

                entity.Property(e => e.F_JsEvent)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("事件");

                entity.Property(e => e.F_LastModifyTime)
                    .HasColumnType("datetime")
                    .HasComment("最后修改时间");

                entity.Property(e => e.F_LastModifyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后修改用户");

                entity.Property(e => e.F_Layers).HasComment("层次");

                entity.Property(e => e.F_Location).HasComment("位置");

                entity.Property(e => e.F_ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("模块主键");

                entity.Property(e => e.F_ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("父级");

                entity.Property(e => e.F_SortCode).HasComment("排序码");

                entity.Property(e => e.F_Split).HasComment("分开线");

                entity.Property(e => e.F_UrlAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("连接");
            });

            modelBuilder.Entity<Sys_ModuleForm>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_MODULEFORM")
                    .IsClustered(false);

                entity.HasComment("模块表单");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("表单主键");

                entity.Property(e => e.F_CreatorTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.F_CreatorUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户");

                entity.Property(e => e.F_DeleteMark).HasComment("删除标志");

                entity.Property(e => e.F_DeleteTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.F_DeleteUserId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("删除用户");

                entity.Property(e => e.F_Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.F_EnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("编码");

                entity.Property(e => e.F_EnabledMark).HasComment("有效标志");

                entity.Property(e => e.F_FormJson)
                    .IsUnicode(false)
                    .HasComment("表单控件Json");

                entity.Property(e => e.F_FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.F_LastModifyTime)
                    .HasColumnType("datetime")
                    .HasComment("最后修改时间");

                entity.Property(e => e.F_LastModifyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后修改用户");

                entity.Property(e => e.F_ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("模块主键");

                entity.Property(e => e.F_SortCode).HasComment("排序码");
            });

            modelBuilder.Entity<Sys_ModuleFormInstance>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_MODULEFORMINSTANCE")
                    .IsClustered(false);

                entity.HasComment("模块表单实例");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("表单实例主键");

                entity.Property(e => e.F_CreatorTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.F_CreatorUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户");

                entity.Property(e => e.F_FormId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("表单主键");

                entity.Property(e => e.F_InstanceJson)
                    .IsUnicode(false)
                    .HasComment("表单实例Json");

                entity.Property(e => e.F_ObjectId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("对象主键");

                entity.Property(e => e.F_SortCode).HasComment("排序码");
            });

            modelBuilder.Entity<Sys_Organize>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_ORGANIZE")
                    .IsClustered(false);

                entity.HasComment("组织表");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("组织主键");

                entity.Property(e => e.F_Address)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("联系地址");

                entity.Property(e => e.F_AllowDelete).HasComment("允许删除");

                entity.Property(e => e.F_AllowEdit).HasComment("允许编辑");

                entity.Property(e => e.F_AreaId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("归属区域");

                entity.Property(e => e.F_CategoryId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("分类");

                entity.Property(e => e.F_CreatorTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.F_CreatorUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户");

                entity.Property(e => e.F_DeleteMark).HasComment("删除标志");

                entity.Property(e => e.F_DeleteTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.F_DeleteUserId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("删除用户");

                entity.Property(e => e.F_Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.F_Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("邮箱");

                entity.Property(e => e.F_EnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("编码");

                entity.Property(e => e.F_EnabledMark).HasComment("有效标志");

                entity.Property(e => e.F_Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("传真");

                entity.Property(e => e.F_FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.F_LastModifyTime)
                    .HasColumnType("datetime")
                    .HasComment("最后修改时间");

                entity.Property(e => e.F_LastModifyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后修改用户");

                entity.Property(e => e.F_Layers).HasComment("层次");

                entity.Property(e => e.F_ManagerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("负责人");

                entity.Property(e => e.F_MobilePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("手机");

                entity.Property(e => e.F_ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("父级");

                entity.Property(e => e.F_ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("简称");

                entity.Property(e => e.F_SortCode).HasComment("排序码");

                entity.Property(e => e.F_TelePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("电话");

                entity.Property(e => e.F_WeChat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("微信");
            });

            modelBuilder.Entity<Sys_Role>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_ROLE")
                    .IsClustered(false);

                entity.HasComment("角色表");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("角色主键");

                entity.Property(e => e.F_AllowDelete).HasComment("允许删除");

                entity.Property(e => e.F_AllowEdit).HasComment("允许编辑");

                entity.Property(e => e.F_Category).HasComment("分类:1-角色2-岗位");

                entity.Property(e => e.F_CreatorTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.F_CreatorUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户");

                entity.Property(e => e.F_DeleteMark).HasComment("删除标志");

                entity.Property(e => e.F_DeleteTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.F_DeleteUserId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("删除用户");

                entity.Property(e => e.F_Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.F_EnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("编号");

                entity.Property(e => e.F_EnabledMark).HasComment("有效标志");

                entity.Property(e => e.F_FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.F_LastModifyTime)
                    .HasColumnType("datetime")
                    .HasComment("最后修改时间");

                entity.Property(e => e.F_LastModifyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后修改用户");

                entity.Property(e => e.F_OrganizeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("组织主键");

                entity.Property(e => e.F_SortCode).HasComment("排序码");

                entity.Property(e => e.F_Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("类型");
            });

            modelBuilder.Entity<Sys_RoleAuthorize>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_ROLEAUTHORIZE")
                    .IsClustered(false);

                entity.HasComment("角色授权表");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("角色授权主键");

                entity.Property(e => e.F_CreatorTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.F_CreatorUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户");

                entity.Property(e => e.F_ItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("项目主键");

                entity.Property(e => e.F_ItemType).HasComment("项目类型1-模块2-按钮3-列表");

                entity.Property(e => e.F_ObjectId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("对象主键");

                entity.Property(e => e.F_ObjectType).HasComment("对象分类1-角色2-部门-3用户");

                entity.Property(e => e.F_SortCode).HasComment("排序码");
            });

            modelBuilder.Entity<Sys_User>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_USER")
                    .IsClustered(false);

                entity.HasComment("用户表");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("用户主键");

                entity.Property(e => e.F_Account)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("账户");

                entity.Property(e => e.F_Birthday)
                    .HasColumnType("datetime")
                    .HasComment("生日");

                entity.Property(e => e.F_CreatorTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.F_CreatorUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户");

                entity.Property(e => e.F_DeleteMark).HasComment("删除标志");

                entity.Property(e => e.F_DeleteTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.F_DeleteUserId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("删除用户");

                entity.Property(e => e.F_DepartmentId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("部门主键");

                entity.Property(e => e.F_Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.F_DutyId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("岗位主键");

                entity.Property(e => e.F_Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("邮箱");

                entity.Property(e => e.F_EnabledMark).HasComment("有效标志");

                entity.Property(e => e.F_Gender).HasComment("性别");

                entity.Property(e => e.F_HeadIcon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("头像");

                entity.Property(e => e.F_IsAdministrator).HasComment("是否管理员");

                entity.Property(e => e.F_LastModifyTime)
                    .HasColumnType("datetime")
                    .HasComment("最后修改时间");

                entity.Property(e => e.F_LastModifyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后修改用户");

                entity.Property(e => e.F_ManagerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("主管主键");

                entity.Property(e => e.F_MobilePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("手机");

                entity.Property(e => e.F_NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("呢称");

                entity.Property(e => e.F_OrganizeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("组织主键");

                entity.Property(e => e.F_RealName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("姓名");

                entity.Property(e => e.F_RoleId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("角色主键");

                entity.Property(e => e.F_SecurityLevel).HasComment("安全级别");

                entity.Property(e => e.F_Signature)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("个性签名");

                entity.Property(e => e.F_SortCode).HasComment("排序码");

                entity.Property(e => e.F_WeChat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("微信");
            });

            modelBuilder.Entity<Sys_UserLogOn>(entity =>
            {
                entity.HasKey(e => e.F_Id)
                    .HasName("PK_SYS_USERLOGON")
                    .IsClustered(false);

                entity.HasComment("用户登录信息表");

                entity.Property(e => e.F_Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("用户登录主键");

                entity.Property(e => e.F_AllowEndTime)
                    .HasColumnType("datetime")
                    .HasComment("允许登录时间结束");

                entity.Property(e => e.F_AllowStartTime)
                    .HasColumnType("datetime")
                    .HasComment("允许登录时间开始");

                entity.Property(e => e.F_AnswerQuestion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("密码提示答案");

                entity.Property(e => e.F_ChangePasswordDate)
                    .HasColumnType("datetime")
                    .HasComment("最后修改密码日期");

                entity.Property(e => e.F_CheckIPAddress).HasComment("是否访问限制");

                entity.Property(e => e.F_FirstVisitTime)
                    .HasColumnType("datetime")
                    .HasComment("第一次访问时间");

                entity.Property(e => e.F_Language)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("系统语言");

                entity.Property(e => e.F_LastVisitTime)
                    .HasColumnType("datetime")
                    .HasComment("最后访问时间");

                entity.Property(e => e.F_LockEndDate)
                    .HasColumnType("datetime")
                    .HasComment("暂停用户结束日期");

                entity.Property(e => e.F_LockStartDate)
                    .HasColumnType("datetime")
                    .HasComment("暂停用户开始日期");

                entity.Property(e => e.F_LogOnCount).HasComment("登录次数");

                entity.Property(e => e.F_MultiUserLogin).HasComment("允许同时有多用户登录");

                entity.Property(e => e.F_PreviousVisitTime)
                    .HasColumnType("datetime")
                    .HasComment("上一次访问时间");

                entity.Property(e => e.F_Question)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("密码提示问题");

                entity.Property(e => e.F_Theme)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("系统样式");

                entity.Property(e => e.F_UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("用户主键");

                entity.Property(e => e.F_UserOnLine).HasComment("在线状态");

                entity.Property(e => e.F_UserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("用户密码");

                entity.Property(e => e.F_UserSecretkey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("用户秘钥");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
