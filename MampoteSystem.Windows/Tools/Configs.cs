using MampoteSystem.Datos;
using MampoteSystem.Windows.Home;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Windows.Tools
{
    public abstract class Configs
    {
        public static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key];

                return result;
                
            }
            catch (ConfigurationErrorsException)
            {
                return "Error leyendo el archivo de configuración.";
            }
        }

        public static string ReadTasa()
        {
            try
            {
                using(UnitOfWork uow = new UnitOfWork())
                {
                    return uow.tasa.readTasa();
                }
            }
            catch(Exception ex)
            {
                Mensaje.MessageBox(Enumerables.Mensajeria.Error, ex);
                return null;
            }

        }

        public static bool setTasa(string newTasa)
        {
            try
            {
                using(UnitOfWork uow = new UnitOfWork())
                {
                    int response = uow.tasa.setTasa(newTasa);

                    if(response > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch(Exception ex)
            {
                Mensaje.MessageBox(Enumerables.Mensajeria.Error, ex);
                return false;
            }
        }

        public static void AddUpdateSetting(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;

                if(settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Mensaje.MessageBox(Enumerables.Mensajeria.Error, "Error leyendo el archivo de configuraciones.");
            }
        }

        public static string GetEditorUser()
        {
            frmMenu HomeMenu = frmMenu.GetInstance();

            return HomeMenu.EditorUser;
        }

        public static string GetNivelAcceso()
        {
            frmMenu HomeMenu = frmMenu.GetInstance();

            return HomeMenu._NivelAcceso;
        }
    }
}
