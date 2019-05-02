﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Foood
{
  public class SandwichInfo
    {
        public string food { get; set; }
        public string png { get; set; }
        public string imago { get; set; }
        public string texto { get; set; }
    }
    public class Data4
    {
        public List<SandwichInfo> SandwichData { get; set; }
        public void Data_in()
        {
            SandwichData = new List<SandwichInfo>();
            SandwichData.Add(new SandwichInfo() { food = "مثلثات التوست", png = "Assets/Sandwiches/tost.png", imago = "Assets/Sandwiches/ed8169b541fbaf4fdf06f7434209724f.png", texto = "مقادير مثلثات التوست" + "\r\n" + "١ ١⁄٢ كيلوغرام توست، اي ما يعادل كيس" + "\r\n" + "٢ شرحة فلفل أخضر " + "\r\n" + "٣ شرحة طماطم " + "\r\n" + "٤٠٠ غرام جبنة شيدر " + "\r\n" + "٥٠ زيتون، للزينة" + "\r\n" + "طريقة تحضير مثلثات التوست" + "\r\n" + "١. يقطع خبز التوست على شكل مثلثين." + "\r\n" + "٢. يوضع على كل مثلث قطعة من جبنة الشيدار، شرحة فلفل وطماطم ثم يوضع عليها المثلث الثاني." + "\r\n" + "٣. تزين بحبة زيتون وتثبت بخلة أسنان." });
            SandwichData.Add(new SandwichInfo() { food = "وصفة الحواوشى", png = "Assets/Sandwiches/hwawshy.png", imago = "Assets/Sandwiches/f3f19e77dbf060e7d8d508eb9f897688.jpg", texto = "مقادير وصفة الحواوشى" + "\r\n" + "١⁄٢ كيلوغرام لحم مفروم " + "\r\n" + "٥ رغيف خبز " + "\r\n" + "٢٥٠ غرام دهن خروف " + "\r\n" + "١ بصلة وسط، مفرومة ناعم" + "\r\n" + "٢ فلفل أخضر " + "\r\n" + "١⁄٤ كوب زيت " + "\r\n" + "رشة ملح " + "\r\n" + "رشة فلفل اسود " + "\r\n" + "رشة كمون " + "\r\n" + "٢ حبهان " + "\r\n" + "طريقة تحضير وصفة الحواوشى" + "\r\n" + "١. تفرم البصلة ناعم جداً وتوضع في وعاء جانباً." + "\r\n" + "٢. يقطع الفلفل الأخضر قطع صغيرة وتوضع فوق البصل." + "\r\n" + "٣. يضاف الملح، الفلفل، الكمون والحبهان إلى البصل ثم توضع اللحمة فوق التتبيلة." + "\r\n" + "٤. تبرش قطعة صغيرة من دهن الخروف فوق الخليط ويقلب جيداً ثم يوضع في الثلاجة لمدة ساعة." + "\r\n" + "٥. يخرج الوعاء من الثلاجة، يصنع فتحة صغيرة من الجانب في رغيف الخبز ثم تفرد قطعة من اللحم فيه." + "\r\n" + "٦. يدهن وجه وأسفل العيش بالزيت، يوضع في صينية ويدخل إلى الفرن على الشبكة على نار متوسطة حتى ينضج تماماً، تكرر العملية حتى انتهاء الكمية." + "\r\n" + "٧. يخرج الحواوشي من الفرن، يوضع في طبق ويقدم ساخناً." });
            SandwichData.Add(new SandwichInfo() { food = "برجر مصرى", png = "Assets/Sandwiches/burger.png", imago = "Assets/Sandwiches/venue_standard_10831_2012202_284216880.png", texto = "مقادير برجر مصري" + "\r\n" + "٧٥٠ غرام لحم مفروم ناعم " + "\r\n" + "٢ كوب فول الصويا، مغسول ومنقوع لمدة 15 دقيقة" + "\r\n" + "٣ ملعقة كبيرة كاتشاب " + "\r\n" + "١ ١⁄٢ ملعقة كبيرة بصل بودرة " + "\r\n" + "١ ملعقة صغيره ثوم بودرة " + "\r\n" + "١ ملعقة كبيرة ملح " + "\r\n" + "١ ملعقة صغيره فلفل " + "\r\n" + "١⁄٢ ملعقة صغيره بابريكا " + "\r\n" + "١⁄٢ ملعقة صغيره شطة " + "\r\n" + "طريقة تحضير برجر مصري" + "\r\n" + "١. في وعاء، تخلط كل المكونات جيداً." + "\r\n" + "٢. يصفى فول الصويا من الماء، يضاف إلى خليط اللحم ويخلط جيداً." + "\r\n" + "٣. تشكل أقراص متساوية متوسطة السماكة من خليط اللحم وتوضع جانباً." + "\r\n" + "٤. تدهن مقلاة بالزيت، توضع الأقراص فيها وتقلى من الجهتين." + "\r\n" + "٥. ترفع أقراص البرغر، توضع في طبق وتقدم ساخنة." });
            SandwichData.Add(new SandwichInfo() { food = "عيش بالبسطرمة", png = "Assets/Sandwiches/basterma.png", imago = "Assets/Sandwiches/13902882069574.jpg", texto = "مقادير عيش بالبسطرمة" + "\r\n" + "٥٠٠ غرام دقيق " + "\r\n" + "١ ملعقة كبيرة خميرة " + "\r\n" + "٢ ملعقة كبيرة سكر " + "\r\n" + "٣ ملعقة كبيرة زيت زيتون، او اى زيت اخر" + "\r\n" + "١⁄٢ ملعقة صغيره ملح " + "\r\n" + "ماء دافئة للعجن" + "\r\n" + "الحشو" + "\r\n" + "٢٥٠ غرام بسطرما " + "\r\n" + "٢ فلفل رومي، اى لون مقطه شرائح" + "\r\n" + "١ طماطم كبيرة، مقطعه شرائح" + "\r\n" + "١ بصل، مقطعه شرائح" + "\r\n" + "جبنة تشيدر او رومى او موزاريلا او مثلثات (يمكن وضع اكثر من نوع)" + "\r\n" + "زعتر مجفف " + "\r\n" + "لدهن الوجه" + "\r\n" + "١ ملعقة كبيرة صلصة " + "\r\n" + "١ ملعقة كبيرة زيت " + "\r\n" + "طريقة تحضير عيش بالبسطرمة" + "\r\n" + "١. في وعاء، توضع كل مكونات العجين ما عدا الماء." + "\r\n" + "٢. يسكب الماء بالتدريج للحصول على عجينة لينة متماسكة لا تلتصق باليد." + "\r\n" + "٣. تترك العجينة لترتاح لمدة 45 دقيقة." + "\r\n" + "٤. تقسم العجينة إلى 6 كرات متساوية ثم يفرد العجين ويحشى بالجبنة، البسطرمة، الطماطم، الفلفل، البصل والزعتر." + "\r\n" + "٥. تقفل الكرات ويدهن الوجه بالزيت والصلصة." + "\r\n" + "٦. ترص الكرات في صينية ثم تدخل إلى الفرن لمدة 10 دقائق أو حتى تمام النضج." + "\r\n" + "٧. يخرج العيش بالبسطرمة من الفرن ويقدم ساخناً." + "\r\n" + "" });
            SandwichData.Add(new SandwichInfo() { food = "عيش باللحمة الاسكندرانى", png = "Assets/Sandwiches/alex.png", imago = "Assets/Sandwiches/022112040250ua32ozwo107y.jpg", texto = "مقادير عيش باللحمة اسكندراني" + "\r\n" + "مكونات عجينة الخبز" + "\r\n" + "٦ كوب دقيق " + "\r\n" + "٢ ملعقة كبيرة سمن " + "\r\n" + "٢ ملعقة كبيرة خميرة جافة " + "\r\n" + "١ ملعقة صغيره سكر " + "\r\n" + "١ ملعقة صغيره ملح " + "\r\n" + "٢ كوب ماء، تقريبا للعجن" + "\r\n" + "مكونات خلطة اللحم" + "\r\n" + "٥٠٠ غرام لحم بقر مفروم " + "\r\n" + "١٠٠ غرام دهن خروف، و ليه ضانى ( اذا وجد )" + "\r\n" + "٣ بصل متوسط الحجم " + "\r\n" + "١ باقة بقدونس " + "\r\n" + "٢ ملعقة صغيره ملح " + "\r\n" + "٢ ملعقة صغيره فلفل أسود " + "\r\n" + "٣ ملعقة صغيره بهارات لحمة " + "\r\n" + "جوزة الطيب قليل" + "\r\n" + "طريقة تحضير عيش باللحمة اسكندراني" + "\r\n" + "١. في وعاء، يخلط الدقيق، الخميرة، الملح والسكر جيداً ثم يضاف السمن ويخلط جيداً." + "\r\n" + "٢. يضاف الماء تدريجياً إلى الخليط وتعجن للحصول على العجينة المطلوبة." + "\r\n" + "٣. تترك العجينة لتتخمر في مكان دافئ و مغطى لمدة 30 دقيقة." + "\r\n" + "٤. يخلط اللحم في وعاء مع الدهون، البهارات، البصل والبقدونس جيداً، يوضعوا جانباً." + "\r\n" + "٥. يرش على المائدة القليل من الدقيق، توضع قطعة من العجين وتفرد بالنشابة للحصول على الحجم والسماكة المطلوبة. " + "\r\n" + "٦. الكمية المقترحة تعمل تقريبا 12 ساندوتش." + "\r\n" + "٧. توضع قطعة من اللحم في نصف الرغيف ويفضل ان تكون غير سميكة." + "\r\n" + "٨. يغلق النصف الفارغ على النصف الممتلئ باللحم ليصبح على شكل نصف رغيف مغلق." + "\r\n" + "٩. في مقلاة، تسخن ملعقة زيت ثم يوضع الرغيف على نار هادئة ويقلب كل دقيقتين للحصول على اللون المطلوب." + "\r\n" + "١٠. تكرر العملية حتى انتهاء الكمية، يوضع العيش في طبق التقديم ويقدم ساخناً. " });
            SandwichData.Add(new SandwichInfo() { food = "الطعمية المصرية", png = "Assets/Sandwiches/sss.png", imago = "Assets/Sandwiches/trmiaaa.jpg", texto = "مقادير الطعمية المصرية" + "\r\n" + "١⁄٢ كيلوغرام فول، مدشوش" + "\r\n" + "١ كوب بقدونس مفروم " + "\r\n" + "١ كوب كزبرة طازجة، مفرومة" + "\r\n" + "١ كوب كراث، او بصل أخضر قطع" + "\r\n" + "١ بصلة كبيرة، مفرومة" + "\r\n" + "٢ فص ثوم، مفروم" + "\r\n" + "١ ١⁄٢ كوب زيت نباتي للقلي " + "\r\n" + "٢ ملعقة صغيره سمسم " + "\r\n" + "٢ ملعقة كبيرة كزبرة، مطحونة" + "\r\n" + "طريقة تحضير الطعمية المصرية" + "\r\n" + "١. تخلط كل المقادير جيداً، تفرم المكونات في المطحنة جيداً." + "\r\n" + "٢. تشكل العجينة دوائر صغيرة، ترش بالسمسم والكزبرة ثم تحمر في الزيت الساخن." });
        }
    }
}