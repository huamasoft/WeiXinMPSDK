﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Senparc.Weixin.MP.Entities;

namespace Senparc.Weixin.MP.AdvancedAPIs
{
    /// <summary>
    /// 地图服务（map）
    /// 注：地点区域是地点位置的修饰描述，比如：“我现在在皇寺广场远东大厦门口”，起点区域是：“皇寺广场”，起点位置是：“远东大厦门口”。
    /// </summary>
    public class Semantic_MapResult : BaseSemanticResultJson
    {
        public Details_Map details { get; set; }
        /// <summary>
        /// SEARCH 普通查询
        /// ROUTE 路线查询
        /// </summary>
        public string intent { get; set; }
    }

    public class Details_Map
    {
        /// <summary>
        /// 起点区域
        /// </summary>
        public Semantic_Location start_area { get; set; }
        /// <summary>
        /// 起点位置
        /// </summary>
        public Semantic_Location start_loc { get; set; }
        /// <summary>
        /// 终点区域
        /// </summary>
        public Semantic_Location end_area { get; set; }
        /// <summary>
        /// 终点位置
        /// </summary>
        public Semantic_Location end_loc { get; set; }
        /// <summary>
        /// 出行方式：walk（步行）, taxi（打车）, bus（公交）, subway（地铁）, drive（自驾）
        /// </summary>
        public string route_type { get; set; }
        /// <summary>
        /// 公交车号
        /// </summary>
        public int bus_num { get; set; }
        /// <summary>
        /// 地铁线
        /// </summary>
        public string subway_num { get; set; }
        /// <summary>
        /// 排序类型：0较快捷（默认），1少换乘，2少步行
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 关键词
        /// </summary>
        public string keyword { get; set; }
    }
}
