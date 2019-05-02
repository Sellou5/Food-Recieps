﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Foood
{
  public class JuiceInfo
    {
        public string food { get; set; }
        public string png { get; set; }
        public string imago { get; set; }
        public string texto { get; set; }
    }
    public class Data5
    {
        public List<JuiceInfo> JuiceData { get; set; }
        public void Data_in()
        {
            JuiceData = new List<JuiceInfo>();
            JuiceData.Add(new JuiceInfo() { food = "مشروب الكركديه", png = "Assets/juice/krkdeh.png", imago = "Assets/juice/71e3586d2f3da157b61c2509426026ad.jpg", texto = "مقادير مشروب الكركديه" + "\r\n" + "1/8 كوب كركديه " + "\r\n" + "1.25 كوب ماء " + "\r\n" + "سكر، حسب الرغبة" + "\r\n" + "طريقة تحضير مشروب الكركديه" + "\r\n" + "١. يغلي الكركديه في ماء ويضاف سكر حسب الرغبه." + "\r\n" + "٢. بعد ما يغلي، نشيله من علي النار، نسيبه نصف ساعه في الفريزر ونطلعه وقت الإفطار." + "\r\n" + "٣. نضرب كميه منه في الخلاط، هيطلع برغوه وتلات الوان." });
            JuiceData.Add(new JuiceInfo() { food = "حمص الشام المصرى", png = "Assets/juice/shaam.png", imago = "Assets/juice/sddd.jpg", texto = "مقادير حمص الشام المصري" + "\r\n" + "2 كوب حمص حب" + "\r\n" + "1 بصله متوسطه" + "\r\n" + "2 فص ثوم" + "\r\n" + "ملح ، حسب الرغبة" + "\r\n" + "فلفل، حسب الرغبة" + "\r\n" + "شطه، حسب الرغبة" + "\r\n" + "ليمون، حسب الرغبة" + "\r\n" + "طريقة تحضير حمص الشام المصري" + "\r\n" + "١. ينقع الحمص لمده 24 ساعه قبل الطهي." + "\r\n" + "٢. يوضع الحمص علي النار لمدة 45 دقيقه لينضج." + "\r\n" + "٣. تبشر البصله بشر ناعم جدا وتوضع علي النار مع معلقة زيت زيتون وتقلب حتى الاحمرار." + "\r\n" + "٤. يوضع فصي ثوم بعد الهرس جيدا علي البصل عند نهايه احمراره." + "\r\n" + "٥. توضع الطماطم بعد البشر ايضا بشر ناعم (يفضل البشر وليس الخلاط )، ثم يوضع الملح والفلفل فقط." + "\r\n" + "٦. يوضع الحمص بعد النضج علي الخليط  بنفس ماء السلق وترك لمدة 5 دقائق ليغلي." + "\r\n" + "٧. يوضع حمص الشام في كاسات التقديم مع الليمون والشطه." });
            JuiceData.Add(new JuiceInfo() { food = "مشروب السوبيا", png = "Assets/juice/sobia.png", imago = "Assets/juice/@128753.jpg", texto = "مقادير مشروب السوبيا" + "\r\n" + "٤ كوب حليب" + "\r\n" + "1.5 كوب سكر" + "\r\n" + "١ كوب ماء مثلج" + "\r\n" + "1/2 كوب حليب بودرة" + "\r\n" + "1/2 كوب نشا" + "\r\n" + "٢ ملعقة كبيرة ارز مسلوق بدون اي اضافات" + "\r\n" + "١ ملعقة كبيرة فانيليا" + "\r\n" + "١ ملعقة صغيرة روح جوز هند" + "\r\n" + "طريقة تحضير مشروب السوبيا" + "\r\n" + "١. توضع كل المكونات في الخلاط وتخلط جيداً." + "\r\n" + "٢. يستمر بالخلط حتي ذوبان الارز ثم تقدم." });
            JuiceData.Add(new JuiceInfo() { food = "الخشاف بالعسل", png = "Assets/juice/khoshaf.png", imago = "Assets/juice/0Khoushaf02.jpg", texto = "مقادير الخشاف المصري بالعسل" + "\r\n" + "٢٠٠ غرام تمر، جاف أي بلح يفضل البلح الأحمر" + "\r\n" + "٢ ملعقة كبيرة عسل " + "\r\n" + "١ كوب ثلج، مجروش" + "\r\n" + "٢ كوب ماء " + "\r\n" + "طريقة تحضير الخشاف المصري بالعسل" + "\r\n" + "١. يغسل البلح ويزال منه النوى ويضرب قليلاً في الخلاط." + "\r\n" + "٢. ينقع البلح في 2 كوب ماء لمدة 12 ساعة." + "\r\n" + "٣. في محضر الطعام، يوضع البلح المنقوع مع الماء، الثلج المجروش والعسل، يضرب لمدة 5 دقائق ثم يصفى الخليط في وعاء التقديم ويقدم." });
            JuiceData.Add(new JuiceInfo() { food = "عصير الفراولة", png = "Assets/juice/frawla.png", imago = "Assets/juice/900x450_uploads,2015,07,08,559c92fce16b3.png", texto = "مقادير عصير الفراولة المصري" + "\r\n" + "١ كيلوغرام فراولة، طازجة وناضجة" + "\r\n" + "٢٠٠ غرام سكر " + "\r\n" + "١⁄٢ كوب ماء " + "\r\n" + "طريقة تحضير عصير الفراولة المصري" + "\r\n" + "١. تغسل الفراولة جيداً مع إزالة العنق الاخضر منها، توضع فى اناء ذو غطاء محكم بعد رش السكر فقط عليها ثم توضع فى الفريزر 24 ساعة." + "\r\n" + "٢. تخرج من الفريزر، توضع فى البراد 6 ساعات حتى تذوب." + "\r\n" + "٣. قبل التقديم يتم إضافة نصف كوب ماء عليها وتصب فى أكواب مع ملاعق صغيرة للاكل." });
            JuiceData.Add(new JuiceInfo() { food = "السحلب المصرى", png = "Assets/juice/sa7lb.png", imago = "Assets/juice/4e3ba8345d.jpg", texto = "مقادير السحلب المصري" + "\r\n" + "٢ كوب حليب سائل " + "\r\n" + "١ ملعقة كبيرة سحلب بودرة " + "\r\n" + "١ ملعقة كبيرة سكر " + "\r\n" + "جوز الهند وقرفة للتزين" + "\r\n" + "طريقة تحضير السحلب المصري" + "\r\n" + "١. يوضع ½1 كوب حليب على النار حتى يغلي." + "\r\n" + "٢. تذوب بودرة السحلب بكمية الحليب الباقية وتضاف مع السكر على الحليب الساخن، يخفق السحلب بالخفاقة اليدوية حوالي 3 دقائق او حتى يصل للسماكة المرغوبة ثم يرفع عن النار." + "\r\n" + "٣. يسكب السحلب بأكواب ثم يزين بالقرفة وجوز الهند ويقدم فوراً." });
        }
    }
}
