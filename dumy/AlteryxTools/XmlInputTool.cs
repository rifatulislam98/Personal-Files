using AlteryxGuiToolkit.Document;
using AlteryxGuiToolkit.Plugins;
using System.Windows.Forms;
using System.Xml;

namespace AlteryxTools
{
    public class XmlInputTool : AlteryxGuiToolkit.Plugins.IPlugin
    {
        public IPluginConfiguration GetConfigurationGui()
        {
            return  new XmlInputToolGui();
        }

        public EntryPoint GetEngineEntryPoint()
        {
            return new AlteryxGuiToolkit.Plugins.EntryPoint("AlteryxTools.dll", "AlteryxTools.XmlInputToolEngine", true);
        }

        public System.Drawing.Image GetIcon()
        {
            throw new NotImplementedException();
        }

        public Connection[] GetInputConnections()
        {
            throw new NotImplementedException();
        }

        public Connection[] GetOutputConnections()
        {
            throw new NotImplementedException();
        }
    }

    public class XmlInputToolGui : IPluginConfiguration
    {
        public Control GetConfigurationControl(Properties docProperties, XmlElement eConfig, XmlElement[] eIncomingMetaInfo, int nToolId, string strToolName)
        {
            var control = new Control();

            return control;
        }

        public void SaveResultsToXml(XmlElement eConfig, out string strDefaultAnnotation)
        {
            throw new NotImplementedException();
        }
    }
}
