using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// to deal with map info
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
// to deal with adding new layer
using ESRI.ArcGIS.DataSourcesGDB;
// to check the shape of the feature
using ESRI.ArcGIS.Geometry;

namespace ProjectGIS
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        IMapDocument MapDocument;
        private void addmaps_Click(object sender, EventArgs e)
        {
            listShowMaps.Items.Clear();
            // Create Variable of MapDocumentClass and interface IMapDocument
             MapDocument = new MapDocumentClass();
            // Get map document from path
            MapDocument.Open(@"C:\Data\Maps\Map1.mxd");
            //to open first map
            IMap map = MapDocument.get_Map(0);
            axMapControl1.Map = map;
            IActiveView actv = map as IActiveView;
            axMapControl1.ActiveView.Extent = actv.Extent;
            axMapControl1.Refresh();

            for (int i = 0; i < MapDocument.MapCount; i++)
            {
                listShowMaps.Items.Add(MapDocument.get_Map(i).Name);
            }
           


        }

        private void axMapControl1_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
        {
            cordinatexy.Text = e.mapX.ToString() + " " + e.mapY.ToString();
        }

        private void loadlayers_Click(object sender, EventArgs e)
        {
            IMap map = MapDocument.get_Map(listShowMaps.SelectedIndex);
            axMapControl1.Map = map;
            IActiveView actv = map as IActiveView;
            axMapControl1.ActiveView.Extent = actv.Extent;
            axMapControl1.Refresh();

            listLayers.Items.Clear();


            IEnumLayer mapLayers = map.get_Layers();
            //to access specific layer use next pointer
            ILayer layer = mapLayers.Next();
            //loop for all layers 
            while (layer != null)
            {

                listLayers.Items.Add(layer.Name);
                layer.Visible = true;
                layer = mapLayers.Next();

            }






        }

        private void axMapControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            cordinatexy.Text = e.mapX + "  ,  " + e.mapY;
        }

        private void addlayerbtn_Click(object sender, EventArgs e)
        {
            IMap foucusMap = axMapControl1.ActiveView.FocusMap;

            IWorkspaceFactory workspaceFact = new AccessWorkspaceFactoryClass();
            IWorkspace workspace;
            workspace = workspaceFact.OpenFromFile(@"C:\Data\GIS Databases\Wilson.mdb", 0);

            IFeatureWorkspace featworkspace = workspace as IFeatureWorkspace;
            IFeatureClass featclass;

            featclass = featworkspace.OpenFeatureClass("City_Centerlines");
            IFeatureLayer featlayer = new FeatureLayerClass();

            featlayer.FeatureClass = featclass;

            featlayer.Name = "Wilson";

            foucusMap.AddLayer(featlayer);

            foucusMap.MoveLayer(featlayer, 2);
            RefreshLayer();
        }
        private void RefreshLayer() {
            ILayer alyer;
            IEnumLayer allLayers;
            listLayers.Items.Clear();
            allLayers = axMapControl1.ActiveView.FocusMap.get_Layers(null, true);
            alyer = allLayers.Next();
            while (alyer != null)
            {
                listLayers.Items.Add(alyer.Name);
                alyer = allLayers.Next();
            }

            axMapControl1.Refresh();
        
        
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void removelayer_Click(object sender, EventArgs e)
        {
            IMap foucusMap = axMapControl1.ActiveView.FocusMap;
            IFeatureLayer feachLater = getLayerByName(listLayers.Text);
            foucusMap.DeleteLayer(feachLater);
            RefreshLayer();

           

        }
        private IFeatureLayer getLayerByName(string layerName)
        {
            IEnumLayer allLayers;
            allLayers = axMapControl1.ActiveView.FocusMap.get_Layers(null, true);
            ILayer layer = allLayers.Next();
            while (layer != null)
            {
                if (layer.Name == layerName)
                {
                    return ((IFeatureLayer)(layer));
                }
                layer = allLayers.Next();
            }
            return null;

        }
        private void defquery_Click(object sender, EventArgs e)
        {
            IMap map = axMapControl1.ActiveView.FocusMap;
            IFeatureLayer feachLater = getLayerByName(listLayers.Text);
            IFeatureLayerDefinition layerDef = feachLater as IFeatureLayerDefinition;
            layerDef.DefinitionExpression = userquery.Text;
            axMapControl1.ActiveView.Refresh();

        }

        private void visiblebutton_Click(object sender, EventArgs e)
        {
            if (visibality_check.Checked == true)
            {
                IMap map = MapDocument.get_Map(listShowMaps.SelectedIndex);
                axMapControl1.Map = map;
                IActiveView actv = map as IActiveView;
                axMapControl1.ActiveView.Extent = actv.Extent;
                axMapControl1.Refresh();

                ILayer maplayer;
                maplayer = map.get_Layer(listLayers.SelectedIndex);

                maplayer.Visible = false;

                IActiveView view = (IActiveView)map;
                view.Refresh();
            }
            else {


                IMap map = MapDocument.get_Map(listShowMaps.SelectedIndex);
                axMapControl1.Map = map;
                IActiveView actv = map as IActiveView;
                axMapControl1.ActiveView.Extent = actv.Extent;
                axMapControl1.Refresh();

                ILayer maplayer;
                maplayer = map.get_Layer(listLayers.SelectedIndex);

                maplayer.Visible = true;

                IActiveView view = (IActiveView)map;
                view.Refresh();
            
            
            }

            }

        private void visibality_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void zoomin_Click(object sender, EventArgs e)
        {
            IMap map = MapDocument.get_Map(listShowMaps.SelectedIndex);
            axMapControl1.Map = map;
            IActiveView actv = map as IActiveView;
            axMapControl1.ActiveView.Extent = actv.FullExtent;
            axMapControl1.Refresh();
        }

        private void extent_Click(object sender, EventArgs e)
        {
            IMap map = MapDocument.get_Map(listShowMaps.SelectedIndex);
            axMapControl1.Map = map;
            IActiveView actv = map as IActiveView;
            axMapControl1.ActiveView.Extent = actv.FullExtent;
            axMapControl1.Refresh();
        }

      
        
        private void zoomin_Click_1(object sender, EventArgs e)
        {
           
            IMap map = axMapControl1.ActiveView.FocusMap;
            double num = map.MapScale;
            double scal = num * 0.2;
            map.MapScale = scal;
            axMapControl1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IMap map = axMapControl1.ActiveView.FocusMap;
            double num = map.MapScale;
            double scal = num / 0.2;
            map.MapScale = scal;
            axMapControl1.Refresh();
        }

       

        }

       

    }
