using System;

namespace AdminUI.Code.Web
{
    public class Paginated
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public int page { get; set; }
        /// <summary>
        /// 每页行数
        /// </summary>
        public int limit { get; set; }

        public int pageSize { get; set; }
        public int pageIndex { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        public int records { get; set; }

        /// <summary>
        /// 排序列
        /// </summary>

        /// <summary>
        /// 排序类型
        /// </summary>
        public string sord { get; set; }

        public string selectid { get; set; }
        public DateTime stardate { get; set; }
        public DateTime enddate { get; set; }
        public int total
        {
            get
            {
                if (records > 0)
                {
                    return records % this.limit == 0 ? records / this.limit : records / this.limit + 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
