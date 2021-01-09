using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 阴阳师辅助
{
    class MyClass
    {
        public static void ShowForm(string formName)
        {
            if (formName == "式神信息")
            {
                Forms.Heros formHeros = new Forms.Heros();
                formHeros.ShowDialog();
                formHeros.Dispose();
            }
            if (formName=="式神攻略")
            {
                Forms.HeroStrategy formHeroStrategy = new Forms.HeroStrategy();
                formHeroStrategy.ShowDialog();
                formHeroStrategy.Dispose();
            }
            if (formName=="悬赏封印")
            {
                Forms.Explore formExplore = new Forms.Explore();
                formExplore.ShowDialog();
                formExplore.Dispose();
            }
            if (formName == "秘闻副本")
            {
                Forms.Secret formSecret = new Forms.Secret();
                formSecret.ShowDialog();
                formSecret.Dispose();
            }
        }
    }
}
