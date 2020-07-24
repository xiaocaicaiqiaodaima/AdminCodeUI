using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminUI.Date.Migrations
{
    public partial class mysql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mstb_monitorcurrent",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ip_Address = table.Column<string>(nullable: true),
                    Address_Index = table.Column<string>(nullable: false),
                    Monitor_Name = table.Column<string>(nullable: true),
                    Monitor_Value = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Monitor_Time = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mstb_monitorcurrent", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "mstb_monitorhistory",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ip_Address = table.Column<string>(nullable: true),
                    Address_Index = table.Column<string>(nullable: false),
                    Monitor_Name = table.Column<string>(nullable: true),
                    Monitor_Value = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Monitor_Time = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mstb_monitorhistory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "mstb_monitorstate",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ip_Address = table.Column<string>(nullable: true),
                    Address_Index = table.Column<string>(nullable: false),
                    Monitor_Name = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Monitor_Time = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mstb_monitorstate", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Area",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "主键"),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "父级"),
                    F_Layers = table.Column<int>(nullable: true, comment: "层次"),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "编码"),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "名称"),
                    F_SimpleSpelling = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "简拼"),
                    F_SortCode = table.Column<int>(nullable: true, comment: "排序码"),
                    F_DeleteMark = table.Column<bool>(nullable: true, comment: "删除标志"),
                    F_EnabledMark = table.Column<bool>(nullable: true, comment: "有效标志"),
                    F_Description = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "描述"),
                    F_CreatorTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "创建日期"),
                    F_CreatorUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "创建用户主键"),
                    F_LastModifyTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "最后修改时间"),
                    F_LastModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "最后修改用户"),
                    F_DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    F_DeleteUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "删除用户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_AREA", x => x.F_Id);
                },
                comment: "行政区域表");

            migrationBuilder.CreateTable(
                name: "Sys_DbBackup",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "备份主键"),
                    F_BackupType = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "备份类型"),
                    F_DbName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "数据库名称"),
                    F_FileName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "文件名称"),
                    F_FileSize = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "文件大小"),
                    F_FilePath = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "文件路径"),
                    F_BackupTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "备份时间"),
                    F_SortCode = table.Column<int>(nullable: true, comment: "排序码"),
                    F_DeleteMark = table.Column<bool>(nullable: true, comment: "删除标志"),
                    F_EnabledMark = table.Column<bool>(nullable: true, comment: "有效标志"),
                    F_Description = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "描述"),
                    F_CreatorTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "创建时间"),
                    F_CreatorUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "创建用户"),
                    F_LastModifyTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "最后修改时间"),
                    F_LastModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "最后修改用户"),
                    F_DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    F_DeleteUserId = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "删除用户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_DBBACKUP", x => x.F_Id);
                },
                comment: "数据库备份");

            migrationBuilder.CreateTable(
                name: "Sys_FilterIP",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "过滤主键"),
                    F_Type = table.Column<bool>(nullable: true, comment: "类型"),
                    F_StartIP = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "开始IP"),
                    F_EndIP = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "结束IP"),
                    F_SortCode = table.Column<int>(nullable: true, comment: "排序码"),
                    F_DeleteMark = table.Column<bool>(nullable: true, comment: "删除标志"),
                    F_EnabledMark = table.Column<bool>(nullable: true, comment: "有效标志"),
                    F_Description = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "描述"),
                    F_CreatorTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "创建时间"),
                    F_CreatorUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "创建用户"),
                    F_LastModifyTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "最后修改时间"),
                    F_LastModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "最后修改用户"),
                    F_DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    F_DeleteUserId = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "删除用户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_FILTERIP", x => x.F_Id);
                },
                comment: "过滤IP");

            migrationBuilder.CreateTable(
                name: "Sys_Items",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "主表主键"),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "父级"),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "编码"),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "名称"),
                    F_IsTree = table.Column<bool>(nullable: true, comment: "树型"),
                    F_Layers = table.Column<int>(nullable: true, comment: "层次"),
                    F_SortCode = table.Column<int>(nullable: true, comment: "排序码"),
                    F_DeleteMark = table.Column<bool>(nullable: true, comment: "删除标志"),
                    F_EnabledMark = table.Column<bool>(nullable: true, comment: "有效标志"),
                    F_Description = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "描述"),
                    F_CreatorTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "创建日期"),
                    F_CreatorUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "创建用户主键"),
                    F_LastModifyTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "最后修改时间"),
                    F_LastModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "最后修改用户"),
                    F_DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    F_DeleteUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "删除用户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_ITEMS", x => x.F_Id);
                },
                comment: "选项主表");

            migrationBuilder.CreateTable(
                name: "Sys_ItemsDetail",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "明细主键"),
                    F_ItemId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "主表主键"),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "父级"),
                    F_ItemCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "编码"),
                    F_ItemName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "名称"),
                    F_SimpleSpelling = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "简拼"),
                    F_IsDefault = table.Column<bool>(nullable: true, comment: "默认"),
                    F_Layers = table.Column<int>(nullable: true, comment: "层次"),
                    F_SortCode = table.Column<int>(nullable: true, comment: "排序码"),
                    F_DeleteMark = table.Column<bool>(nullable: true, comment: "删除标志"),
                    F_EnabledMark = table.Column<bool>(nullable: true, comment: "有效标志"),
                    F_Description = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "描述"),
                    F_CreatorTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "创建日期"),
                    F_CreatorUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "创建用户主键"),
                    F_LastModifyTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "最后修改时间"),
                    F_LastModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "最后修改用户"),
                    F_DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    F_DeleteUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "删除用户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_ITEMDETAIL", x => x.F_Id);
                },
                comment: "选项明细表");

            migrationBuilder.CreateTable(
                name: "Sys_Log",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "日志主键"),
                    F_Date = table.Column<DateTime>(type: "datetime", nullable: true, comment: "日期"),
                    F_Account = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "用户名"),
                    F_NickName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "姓名"),
                    F_Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "类型"),
                    F_IPAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "IP地址"),
                    F_IPAddressName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "IP所在城市"),
                    F_ModuleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "系统模块Id"),
                    F_ModuleName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "系统模块"),
                    F_Result = table.Column<bool>(nullable: true, comment: "结果"),
                    F_Description = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "描述"),
                    F_CreatorTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "创建时间"),
                    F_CreatorUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "创建用户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_LOG", x => x.F_Id);
                },
                comment: "系统日志");

            migrationBuilder.CreateTable(
                name: "Sys_Module",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "模块主键"),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "父级"),
                    F_Layers = table.Column<int>(nullable: true, comment: "层次"),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "编码"),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "名称"),
                    F_Icon = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "图标"),
                    F_UrlAddress = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "连接"),
                    F_Target = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "目标"),
                    F_IsMenu = table.Column<bool>(nullable: true, comment: "菜单"),
                    F_IsExpand = table.Column<bool>(nullable: true, comment: "展开"),
                    F_IsPublic = table.Column<bool>(nullable: true, comment: "公共"),
                    F_AllowEdit = table.Column<bool>(nullable: true, comment: "允许编辑"),
                    F_AllowDelete = table.Column<bool>(nullable: true, comment: "允许删除"),
                    F_SortCode = table.Column<int>(nullable: true, comment: "排序码"),
                    F_DeleteMark = table.Column<bool>(nullable: true, comment: "删除标志"),
                    F_EnabledMark = table.Column<bool>(nullable: true, comment: "有效标志"),
                    F_Description = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "描述"),
                    F_CreatorTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "创建日期"),
                    F_CreatorUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "创建用户主键"),
                    F_LastModifyTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "最后修改时间"),
                    F_LastModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "最后修改用户"),
                    F_DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    F_DeleteUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "删除用户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_MODULE", x => x.F_Id);
                },
                comment: "系统模块");

            migrationBuilder.CreateTable(
                name: "Sys_ModuleButton",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "按钮主键"),
                    F_ModuleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "模块主键"),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "父级"),
                    F_Layers = table.Column<int>(nullable: true, comment: "层次"),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "编码"),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "名称"),
                    F_Icon = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "图标"),
                    F_Location = table.Column<int>(nullable: true, comment: "位置"),
                    F_JsEvent = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "事件"),
                    F_UrlAddress = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "连接"),
                    F_Split = table.Column<bool>(nullable: true, comment: "分开线"),
                    F_IsPublic = table.Column<bool>(nullable: true, comment: "公共"),
                    F_AllowEdit = table.Column<bool>(nullable: true, comment: "允许编辑"),
                    F_AllowDelete = table.Column<bool>(nullable: true, comment: "允许删除"),
                    F_SortCode = table.Column<int>(nullable: true, comment: "排序码"),
                    F_DeleteMark = table.Column<bool>(nullable: true, comment: "删除标志"),
                    F_EnabledMark = table.Column<bool>(nullable: true, comment: "有效标志"),
                    F_Description = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "描述"),
                    F_CreatorTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "创建日期"),
                    F_CreatorUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "创建用户主键"),
                    F_LastModifyTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "最后修改时间"),
                    F_LastModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "最后修改用户"),
                    F_DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    F_DeleteUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "删除用户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_MODULEBUTTON", x => x.F_Id);
                },
                comment: "模块按钮");

            migrationBuilder.CreateTable(
                name: "Sys_ModuleForm",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "表单主键"),
                    F_ModuleId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "模块主键"),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "编码"),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "名称"),
                    F_FormJson = table.Column<string>(unicode: false, nullable: true, comment: "表单控件Json"),
                    F_SortCode = table.Column<int>(nullable: true, comment: "排序码"),
                    F_DeleteMark = table.Column<bool>(nullable: true, comment: "删除标志"),
                    F_EnabledMark = table.Column<bool>(nullable: true, comment: "有效标志"),
                    F_Description = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "描述"),
                    F_CreatorTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "创建时间"),
                    F_CreatorUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "创建用户"),
                    F_LastModifyTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "最后修改时间"),
                    F_LastModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "最后修改用户"),
                    F_DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    F_DeleteUserId = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "删除用户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_MODULEFORM", x => x.F_Id);
                },
                comment: "模块表单");

            migrationBuilder.CreateTable(
                name: "Sys_ModuleFormInstance",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "表单实例主键"),
                    F_FormId = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "表单主键"),
                    F_ObjectId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "对象主键"),
                    F_InstanceJson = table.Column<string>(unicode: false, nullable: true, comment: "表单实例Json"),
                    F_SortCode = table.Column<int>(nullable: true, comment: "排序码"),
                    F_CreatorTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "创建时间"),
                    F_CreatorUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "创建用户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_MODULEFORMINSTANCE", x => x.F_Id);
                },
                comment: "模块表单实例");

            migrationBuilder.CreateTable(
                name: "Sys_Organize",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "组织主键"),
                    F_ParentId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "父级"),
                    F_Layers = table.Column<int>(nullable: true, comment: "层次"),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "编码"),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "名称"),
                    F_ShortName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "简称"),
                    F_CategoryId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "分类"),
                    F_ManagerId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "负责人"),
                    F_TelePhone = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "电话"),
                    F_MobilePhone = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "手机"),
                    F_WeChat = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "微信"),
                    F_Fax = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "传真"),
                    F_Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "邮箱"),
                    F_AreaId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "归属区域"),
                    F_Address = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "联系地址"),
                    F_AllowEdit = table.Column<bool>(nullable: true, comment: "允许编辑"),
                    F_AllowDelete = table.Column<bool>(nullable: true, comment: "允许删除"),
                    F_SortCode = table.Column<int>(nullable: true, comment: "排序码"),
                    F_DeleteMark = table.Column<bool>(nullable: true, comment: "删除标志"),
                    F_EnabledMark = table.Column<bool>(nullable: true, comment: "有效标志"),
                    F_Description = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "描述"),
                    F_CreatorTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "创建时间"),
                    F_CreatorUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "创建用户"),
                    F_LastModifyTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "最后修改时间"),
                    F_LastModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "最后修改用户"),
                    F_DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    F_DeleteUserId = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "删除用户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_ORGANIZE", x => x.F_Id);
                },
                comment: "组织表");

            migrationBuilder.CreateTable(
                name: "Sys_Role",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "角色主键"),
                    F_OrganizeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "组织主键"),
                    F_Category = table.Column<int>(nullable: true, comment: "分类:1-角色2-岗位"),
                    F_EnCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "编号"),
                    F_FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "名称"),
                    F_Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "类型"),
                    F_AllowEdit = table.Column<bool>(nullable: true, comment: "允许编辑"),
                    F_AllowDelete = table.Column<bool>(nullable: true, comment: "允许删除"),
                    F_SortCode = table.Column<int>(nullable: true, comment: "排序码"),
                    F_DeleteMark = table.Column<bool>(nullable: true, comment: "删除标志"),
                    F_EnabledMark = table.Column<bool>(nullable: true, comment: "有效标志"),
                    F_Description = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "描述"),
                    F_CreatorTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "创建时间"),
                    F_CreatorUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "创建用户"),
                    F_LastModifyTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "最后修改时间"),
                    F_LastModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "最后修改用户"),
                    F_DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    F_DeleteUserId = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "删除用户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_ROLE", x => x.F_Id);
                },
                comment: "角色表");

            migrationBuilder.CreateTable(
                name: "Sys_RoleAuthorize",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "角色授权主键"),
                    F_ItemType = table.Column<int>(nullable: true, comment: "项目类型1-模块2-按钮3-列表"),
                    F_ItemId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "项目主键"),
                    F_ObjectType = table.Column<int>(nullable: true, comment: "对象分类1-角色2-部门-3用户"),
                    F_ObjectId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "对象主键"),
                    F_SortCode = table.Column<int>(nullable: true, comment: "排序码"),
                    F_CreatorTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "创建时间"),
                    F_CreatorUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "创建用户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_ROLEAUTHORIZE", x => x.F_Id);
                },
                comment: "角色授权表");

            migrationBuilder.CreateTable(
                name: "Sys_User",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "用户主键"),
                    F_Account = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "账户"),
                    F_RealName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "姓名"),
                    F_UserPassword = table.Column<string>(nullable: true),
                    F_NickName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "呢称"),
                    F_HeadIcon = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "头像"),
                    F_Gender = table.Column<bool>(nullable: true, comment: "性别"),
                    F_Birthday = table.Column<DateTime>(type: "datetime", nullable: true, comment: "生日"),
                    F_MobilePhone = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "手机"),
                    F_Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "邮箱"),
                    F_WeChat = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "微信"),
                    F_ManagerId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "主管主键"),
                    F_SecurityLevel = table.Column<int>(nullable: true, comment: "安全级别"),
                    F_Signature = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "个性签名"),
                    F_OrganizeId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "组织主键"),
                    F_DepartmentId = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "部门主键"),
                    F_RoleId = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "角色主键"),
                    F_DutyId = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "岗位主键"),
                    F_IsAdministrator = table.Column<bool>(nullable: true, comment: "是否管理员"),
                    F_SortCode = table.Column<int>(nullable: true, comment: "排序码"),
                    F_DeleteMark = table.Column<bool>(nullable: true, comment: "删除标志"),
                    F_EnabledMark = table.Column<bool>(nullable: true, comment: "有效标志"),
                    F_Description = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "描述"),
                    F_CreatorTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "创建时间"),
                    F_CreatorUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "创建用户"),
                    F_LastModifyTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "最后修改时间"),
                    F_LastModifyUserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "最后修改用户"),
                    F_DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    F_DeleteUserId = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "删除用户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_USER", x => x.F_Id);
                },
                comment: "用户表");

            migrationBuilder.CreateTable(
                name: "Sys_UserLogOn",
                columns: table => new
                {
                    F_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "用户登录主键"),
                    F_UserId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "用户主键"),
                    F_UserPassword = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "用户密码"),
                    F_UserSecretkey = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "用户秘钥"),
                    F_AllowStartTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "允许登录时间开始"),
                    F_AllowEndTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "允许登录时间结束"),
                    F_LockStartDate = table.Column<DateTime>(type: "datetime", nullable: true, comment: "暂停用户开始日期"),
                    F_LockEndDate = table.Column<DateTime>(type: "datetime", nullable: true, comment: "暂停用户结束日期"),
                    F_FirstVisitTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "第一次访问时间"),
                    F_PreviousVisitTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "上一次访问时间"),
                    F_LastVisitTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "最后访问时间"),
                    F_ChangePasswordDate = table.Column<DateTime>(type: "datetime", nullable: true, comment: "最后修改密码日期"),
                    F_MultiUserLogin = table.Column<bool>(nullable: true, comment: "允许同时有多用户登录"),
                    F_LogOnCount = table.Column<int>(nullable: true, comment: "登录次数"),
                    F_UserOnLine = table.Column<bool>(nullable: true, comment: "在线状态"),
                    F_Question = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "密码提示问题"),
                    F_AnswerQuestion = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "密码提示答案"),
                    F_CheckIPAddress = table.Column<bool>(nullable: true, comment: "是否访问限制"),
                    F_Language = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "系统语言"),
                    F_Theme = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "系统样式")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_USERLOGON", x => x.F_Id);
                },
                comment: "用户登录信息表");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mstb_monitorcurrent");

            migrationBuilder.DropTable(
                name: "mstb_monitorhistory");

            migrationBuilder.DropTable(
                name: "mstb_monitorstate");

            migrationBuilder.DropTable(
                name: "Sys_Area");

            migrationBuilder.DropTable(
                name: "Sys_DbBackup");

            migrationBuilder.DropTable(
                name: "Sys_FilterIP");

            migrationBuilder.DropTable(
                name: "Sys_Items");

            migrationBuilder.DropTable(
                name: "Sys_ItemsDetail");

            migrationBuilder.DropTable(
                name: "Sys_Log");

            migrationBuilder.DropTable(
                name: "Sys_Module");

            migrationBuilder.DropTable(
                name: "Sys_ModuleButton");

            migrationBuilder.DropTable(
                name: "Sys_ModuleForm");

            migrationBuilder.DropTable(
                name: "Sys_ModuleFormInstance");

            migrationBuilder.DropTable(
                name: "Sys_Organize");

            migrationBuilder.DropTable(
                name: "Sys_Role");

            migrationBuilder.DropTable(
                name: "Sys_RoleAuthorize");

            migrationBuilder.DropTable(
                name: "Sys_User");

            migrationBuilder.DropTable(
                name: "Sys_UserLogOn");
        }
    }
}
