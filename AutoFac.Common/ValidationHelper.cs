using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac.Common
{
    public class ValidationHelper
    {
        /// <summary>  
        /// 验证身份证合理性  
        /// </summary>  
        /// <param name="idNumber"></param>  
        /// <param name="errMsg"></param>  
        /// <returns></returns>
        /// <remarks>
        /// 18位身份证号码=6位地区代码+8位生日+3位编号+1位检验码
        ///  各省市地区国家代码前两位代码是：     
        ///  北京 11 吉林 22 福建 35 广东 44 云南 53 天津 12 黑龙江 23 江西 36 广西 45 西藏 54 河北 13 上海 31 山东 37 海南 46 陕西 61 山西 14 江苏 32 河南 41 重庆 50 
        ///  甘肃 62 内蒙古 15 浙江 33 湖北 42 四川 51 青海 63 辽宁 21 安徽 34 湖南 43 贵州 52 宁夏 64 新 疆 65 台湾 71 香港 81 澳门 82 国外 91   
        /// 18位身份证标准在国家质量技术监督局于1999年7月1日实施的GB11643-1999《公民身份号码》中做了明确规定。
        /// GB11643-1999《公民身份号码》为GB11643-1989《社会保障号码》的修订版，其中指出将原标准名称“社会保障号码”更名为“公民身份号码”，另外GB11643-1999《公民身份号码》从实施之日起代替GB11643-1989。
        /// 公民身份号码是特征组合码，由十七位数字本体码和一位校验码组成。排列顺序从左至右依次为：六位数字地址码，八位数字出生日期码，三位数字顺序码和一位校验码。其含义如下：
        /// 1. 地址码：表示编码对象常住户口所在县(市、旗、区)的行政区划代码，按GB/T2260的规定执行。
        /// 2. 出生日期码：表示编码对象出生的年、月、日，按GB/T7408的规定执行，年、月、日分别用4位、2位、2位数字表示，之间不用分隔符。
        /// 3. 顺序码：表示在同一地址码所标识的区域范围内，对同年、同月、同日出生的人编定的顺序号，顺序码的奇数分配给男性，偶数分配给女性。
        /// 校验的计算方式：
        /// 1. 对前17位数字本体码加权求和
        /// 公式为：S = Sum(Ai * Wi), i = 0, ... , 16
        /// 其中Ai表示第i位置上的身份证号码数字值，Wi表示第i位置上的加权因子，其各位对应的值依次为： 
        /// 7 9 10 5 8 4 2 1 6 3 7 9 10 5 8 4 2
        /// 2. 以11对计算结果取模
        /// Y = mod(S, 11)
        /// 3. 根据模的值得到对应的校验码对应关系为：
        /// Y值： 0 1 2 3 4 5 6 7 8 9 10
        /// 校验码： 1 0 X 9 8 7 6 5 4 3 2
        /// </remarks>
        public static bool CheckIdCard(string idNumber, out string errMsg)
        {
            errMsg = string.Empty;
            try
            {
                if (idNumber.Length == 18)
                {
                    idNumber = idNumber.ToUpper();
                    var str17 = idNumber.Substring(0, 17);//前17位
                    if (!System.Text.RegularExpressions.Regex.IsMatch(str17, "^\\d+$"))
                    {//前17位 数字验证
                        errMsg = "身份证前17位必须为数字";
                        return false;
                    }

                    string[] province = new string[] { "11", "22", "35", "44", "53", "12", "23", "36", "45", "54", "13", "31", "37", "46", "61", "14", "32", "41", "50", "62", "15", "33", "42", "51", "63", "21", "34", "43", "52", "64", "65", "71", "81", "82", "91" };
                    if (!province.Contains(idNumber.Substring(0, 2)))
                    {//前2位 省份验证
                        errMsg = "身份证所属省份不正确";
                        return false;
                    }

                    //6-14生日验证
                    string birth = idNumber.Substring(6, 8).Insert(6, "-").Insert(4, "-");
                    DateTime time = new DateTime();
                    if (DateTime.TryParse(birth, out time) == false)
                    {
                        errMsg = "身份证生日不正确";
                        return false;
                    }

                    //最后一位校验码验证
                    string[] arrVarifyCode = new string[] { "1", "0", "X", "9", "8", "7", "6", "5", "4", "3", "2" };
                    int[] Wi = new int[] { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
                    char[] Ai = str17.ToCharArray();
                    int sum = 0;
                    for (int i = 0; i < 17; i++)
                    {
                        sum += Wi[i] * int.Parse(Ai[i].ToString());
                    }
                    int y = -1;
                    Math.DivRem(sum, 11, out y);
                    if (arrVarifyCode[y] != idNumber.Substring(17, 1))
                    {
                        errMsg = "身份证校验位不正确";
                        return false;
                    }

                    return true;//符合GB11643-1999标准  
                }
                else
                {
                    errMsg = "身份证位数不正确";
                    return false;
                }
            }
            catch (Exception ex)
            {

                errMsg = ex.Message;
                return false;
            }

        }

        public static bool CheckIdCard(string idNumber)
        {
            var errMsg = string.Empty;
            return CheckIdCard(idNumber, out errMsg);
        }

    }
}

