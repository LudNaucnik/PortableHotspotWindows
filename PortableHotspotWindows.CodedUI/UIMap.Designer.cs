﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace PortableHotspotWindows.CodedUI
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// StartStopNetwork
        /// </summary>
        public void StartStopNetwork()
        {
            #region Variable Declarations
            WinTitleBar uIPortableHotspotWindoTitleBar = this.UIPortableHotspotWindoWindow.UIPortableHotspotWindoTitleBar;
            WinButton uIStartHotspotButton = this.UIPortableHotspotWindoWindow.UIStartHotspotWindow.UIStartHotspotButton;
            WinButton uIShowPassButtonButton = this.UIPortableHotspotWindoWindow.UIShowPassButtonWindow.UIShowPassButtonButton;
            WinMenuItem uIAboutMenuItem = this.UIPortableHotspotWindoWindow.UIMainMenuStripMenuMenuBar.UIAboutMenuItem;
            WinButton uICloseButton = this.UIAboutWindow.UICloseWindow.UICloseButton;
            WinButton uIStopHostspotButton = this.UIPortableHotspotWindoWindow.UIStartHotspotWindow.UIStopHostspotButton;
            WinMenuItem uIExitMenuItem = this.UIPortableHotspotWindoWindow.UIMainMenuStripMenuMenuBar.UIExitMenuItem;
            WinButton uIYesButton = this.UIInformationWindow.UIYesWindow.UIYesButton;
            #endregion

            // Click 'Portable Hotspot Windows' title bar
            Mouse.Click(uIPortableHotspotWindoTitleBar, new Point(212, 10));

            // Click 'Start Hotspot' button
            Mouse.Click(uIStartHotspotButton, new Point(90, 44));

            // Click 'ShowPassButton' button
            Mouse.Click(uIShowPassButtonButton, new Point(12, 11));

            // Click 'About' menu item
            Mouse.Click(uIAboutMenuItem, new Point(17, 13));

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(53, 12));

            // Click 'Stop Hostspot' button
            Mouse.Click(uIStopHostspotButton, new Point(98, 30));

            // Click 'Exit' menu item
            Mouse.Click(uIExitMenuItem, new Point(7, 13));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(49, 12));
        }
        
        /// <summary>
        /// SetShareNetwork - Use 'SetShareNetworkParams' to pass parameters into this method.
        /// </summary>
        public void SetShareNetwork()
        {
            #region Variable Declarations
            WinTitleBar uIPortableHotspotWindoTitleBar = this.UIPortableHotspotWindoWindow.UIPortableHotspotWindoTitleBar;
            WinMenuItem uISetNetworkMenuItem = this.UIPortableHotspotWindoWindow.UIMainMenuStripMenuMenuBar.UISetNetworkMenuItem;
            WinEdit uISSIDTextBoxEdit = this.UISetHotspotWindow.UISSIDTextBoxWindow.UISSIDTextBoxEdit;
            WinEdit uIKeyTextBoxEdit = this.UISetHotspotWindow.UIKeyTextBoxWindow.UIKeyTextBoxEdit;
            WinButton uITOButton = this.UISetHotspotWindow.UIShowPassButtonWindow.UITOButton;
            WinButton uISetButton = this.UISetHotspotWindow.UISetWindow.UISetButton;
            WinButton uIOKButton = this.UIInformationWindow.UIOKWindow.UIOKButton;
            WinButton uIOpenButton = this.UISetHotspotWindow.UIFromNetworkListComboWindow.UIOpenButton;
            WinComboBox uIFromNetworkListComboComboBox = this.UISetHotspotWindow.UIFromNetworkListComboWindow.UIFromNetworkListComboComboBox;
            WinButton uIOpenButton1 = this.UISetHotspotWindow.UIToNetworkListComboBoWindow.UIOpenButton;
            WinComboBox uIToNetworkListComboBoComboBox = this.UISetHotspotWindow.UIToNetworkListComboBoWindow.UIToNetworkListComboBoComboBox;
            WinButton uIShareInternetButton = this.UISetHotspotWindow.UIShareInternetWindow.UIShareInternetButton;
            WinButton uICloseButton = this.UISetHotspotWindow.UISetHotspotTitleBar.UICloseButton;
            WinButton uICloseButton1 = this.UIPortableHotspotWindoWindow.UIPortableHotspotWindoTitleBar.UICloseButton;
            WinButton uIYesButton = this.UIInformationWindow.UIYesWindow.UIYesButton;
            #endregion

            // Click 'Portable Hotspot Windows' title bar
            Mouse.Click(uIPortableHotspotWindoTitleBar, new Point(156, 19));

            // Click 'Set Network' menu item
            Mouse.Click(uISetNetworkMenuItem, new Point(44, 7));

            // Type 'Internet' in 'SSIDTextBox' text box
            uISSIDTextBoxEdit.Text = this.SetShareNetworkParams.UISSIDTextBoxEditText;

            // Type '{Tab}' in 'SSIDTextBox' text box
            Keyboard.SendKeys(uISSIDTextBoxEdit, this.SetShareNetworkParams.UISSIDTextBoxEditSendKeys, ModifierKeys.None);

            // Type '********' in 'KeyTextBox' text box
            Keyboard.SendKeys(uIKeyTextBoxEdit, this.SetShareNetworkParams.UIKeyTextBoxEditSendKeys, true);

            // Click 'To' button
            Mouse.Click(uITOButton, new Point(6, 15));

            // Click 'Set' button
            Mouse.Click(uISetButton, new Point(35, 14));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(39, 16));

            // Click 'Open' button
            Mouse.Click(uIOpenButton, new Point(8, 6));

            // Select 'Ethernet' in 'FromNetworkListComboBox' combo box
            uIFromNetworkListComboComboBox.SelectedItem = this.SetShareNetworkParams.UIFromNetworkListComboComboBoxSelectedItem;

            // Click 'Open' button
            Mouse.Click(uIOpenButton1, new Point(5, 5));

            // Select 'Local Area Connection* 3' in 'ToNetworkListComboBox' combo box
            uIToNetworkListComboBoComboBox.SelectedItem = this.SetShareNetworkParams.UIToNetworkListComboBoComboBoxSelectedItem;

            // Click 'Share Internet' button
            Mouse.Click(uIShareInternetButton, new Point(51, 27));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(28, 13));

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(40, 13));

            // Click 'Close' button
            Mouse.Click(uICloseButton1, new Point(27, 19));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(37, 15));
        }
        
        #region Properties
        public virtual SetShareNetworkParams SetShareNetworkParams
        {
            get
            {
                if ((this.mSetShareNetworkParams == null))
                {
                    this.mSetShareNetworkParams = new SetShareNetworkParams();
                }
                return this.mSetShareNetworkParams;
            }
        }
        
        public UIPortableHotspotWindoWindow UIPortableHotspotWindoWindow
        {
            get
            {
                if ((this.mUIPortableHotspotWindoWindow == null))
                {
                    this.mUIPortableHotspotWindoWindow = new UIPortableHotspotWindoWindow();
                }
                return this.mUIPortableHotspotWindoWindow;
            }
        }
        
        public UIAboutWindow UIAboutWindow
        {
            get
            {
                if ((this.mUIAboutWindow == null))
                {
                    this.mUIAboutWindow = new UIAboutWindow();
                }
                return this.mUIAboutWindow;
            }
        }
        
        public UIInformationWindow UIInformationWindow
        {
            get
            {
                if ((this.mUIInformationWindow == null))
                {
                    this.mUIInformationWindow = new UIInformationWindow();
                }
                return this.mUIInformationWindow;
            }
        }
        
        public UISetHotspotWindow UISetHotspotWindow
        {
            get
            {
                if ((this.mUISetHotspotWindow == null))
                {
                    this.mUISetHotspotWindow = new UISetHotspotWindow();
                }
                return this.mUISetHotspotWindow;
            }
        }
        #endregion
        
        #region Fields
        private SetShareNetworkParams mSetShareNetworkParams;
        
        private UIPortableHotspotWindoWindow mUIPortableHotspotWindoWindow;
        
        private UIAboutWindow mUIAboutWindow;
        
        private UIInformationWindow mUIInformationWindow;
        
        private UISetHotspotWindow mUISetHotspotWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'SetShareNetwork'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class SetShareNetworkParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'Internet' in 'SSIDTextBox' text box
        /// </summary>
        public string UISSIDTextBoxEditText = "Internet";
        
        /// <summary>
        /// Type '{Tab}' in 'SSIDTextBox' text box
        /// </summary>
        public string UISSIDTextBoxEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type '********' in 'KeyTextBox' text box
        /// </summary>
        public string UIKeyTextBoxEditSendKeys = "vEZ4quwEi8ERPf7i6gs7LIIGpBfVid9iIn8WsNad2mF2KUq/Yp968OfDESRb0ZeHRWlHqz/XR304n7a8F" +
            "ag7qw==";
        
        /// <summary>
        /// Select 'Ethernet' in 'FromNetworkListComboBox' combo box
        /// </summary>
        public string UIFromNetworkListComboComboBoxSelectedItem = "Ethernet";
        
        /// <summary>
        /// Select 'Local Area Connection* 3' in 'ToNetworkListComboBox' combo box
        /// </summary>
        public string UIToNetworkListComboBoComboBoxSelectedItem = "Local Area Connection* 3";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIPortableHotspotWindoWindow : WinWindow
    {
        
        public UIPortableHotspotWindoWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Portable Hotspot Windows";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Portable Hotspot Windows");
            #endregion
        }
        
        #region Properties
        public UIPortableHotspotWindoTitleBar UIPortableHotspotWindoTitleBar
        {
            get
            {
                if ((this.mUIPortableHotspotWindoTitleBar == null))
                {
                    this.mUIPortableHotspotWindoTitleBar = new UIPortableHotspotWindoTitleBar(this);
                }
                return this.mUIPortableHotspotWindoTitleBar;
            }
        }
        
        public UIStartHotspotWindow UIStartHotspotWindow
        {
            get
            {
                if ((this.mUIStartHotspotWindow == null))
                {
                    this.mUIStartHotspotWindow = new UIStartHotspotWindow(this);
                }
                return this.mUIStartHotspotWindow;
            }
        }
        
        public UIShowPassButtonWindow UIShowPassButtonWindow
        {
            get
            {
                if ((this.mUIShowPassButtonWindow == null))
                {
                    this.mUIShowPassButtonWindow = new UIShowPassButtonWindow(this);
                }
                return this.mUIShowPassButtonWindow;
            }
        }
        
        public UIMainMenuStripMenuMenuBar UIMainMenuStripMenuMenuBar
        {
            get
            {
                if ((this.mUIMainMenuStripMenuMenuBar == null))
                {
                    this.mUIMainMenuStripMenuMenuBar = new UIMainMenuStripMenuMenuBar(this);
                }
                return this.mUIMainMenuStripMenuMenuBar;
            }
        }
        #endregion
        
        #region Fields
        private UIPortableHotspotWindoTitleBar mUIPortableHotspotWindoTitleBar;
        
        private UIStartHotspotWindow mUIStartHotspotWindow;
        
        private UIShowPassButtonWindow mUIShowPassButtonWindow;
        
        private UIMainMenuStripMenuMenuBar mUIMainMenuStripMenuMenuBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIPortableHotspotWindoTitleBar : WinTitleBar
    {
        
        public UIPortableHotspotWindoTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Portable Hotspot Windows");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Portable Hotspot Windows");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIStartHotspotWindow : WinWindow
    {
        
        public UIStartHotspotWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "StartStopButton";
            this.WindowTitles.Add("Portable Hotspot Windows");
            #endregion
        }
        
        #region Properties
        public WinButton UIStartHotspotButton
        {
            get
            {
                if ((this.mUIStartHotspotButton == null))
                {
                    this.mUIStartHotspotButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIStartHotspotButton.SearchProperties[WinButton.PropertyNames.Name] = "Start Hotspot";
                    this.mUIStartHotspotButton.WindowTitles.Add("Portable Hotspot Windows");
                    #endregion
                }
                return this.mUIStartHotspotButton;
            }
        }
        
        public WinButton UIStopHostspotButton
        {
            get
            {
                if ((this.mUIStopHostspotButton == null))
                {
                    this.mUIStopHostspotButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIStopHostspotButton.SearchProperties[WinButton.PropertyNames.Name] = "Stop Hostspot";
                    this.mUIStopHostspotButton.WindowTitles.Add("Portable Hotspot Windows");
                    #endregion
                }
                return this.mUIStopHostspotButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIStartHotspotButton;
        
        private WinButton mUIStopHostspotButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIShowPassButtonWindow : WinWindow
    {
        
        public UIShowPassButtonWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "ShowPassButton";
            this.WindowTitles.Add("Portable Hotspot Windows");
            #endregion
        }
        
        #region Properties
        public WinButton UIShowPassButtonButton
        {
            get
            {
                if ((this.mUIShowPassButtonButton == null))
                {
                    this.mUIShowPassButtonButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIShowPassButtonButton.WindowTitles.Add("Portable Hotspot Windows");
                    #endregion
                }
                return this.mUIShowPassButtonButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIShowPassButtonButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIMainMenuStripMenuMenuBar : WinMenuBar
    {
        
        public UIMainMenuStripMenuMenuBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Portable Hotspot Windows");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UIAboutMenuItem
        {
            get
            {
                if ((this.mUIAboutMenuItem == null))
                {
                    this.mUIAboutMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIAboutMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "About";
                    this.mUIAboutMenuItem.WindowTitles.Add("Portable Hotspot Windows");
                    #endregion
                }
                return this.mUIAboutMenuItem;
            }
        }
        
        public WinMenuItem UIExitMenuItem
        {
            get
            {
                if ((this.mUIExitMenuItem == null))
                {
                    this.mUIExitMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIExitMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Exit";
                    this.mUIExitMenuItem.WindowTitles.Add("Portable Hotspot Windows");
                    #endregion
                }
                return this.mUIExitMenuItem;
            }
        }
        
        public WinMenuItem UISetNetworkMenuItem
        {
            get
            {
                if ((this.mUISetNetworkMenuItem == null))
                {
                    this.mUISetNetworkMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUISetNetworkMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Set Network";
                    this.mUISetNetworkMenuItem.WindowTitles.Add("Portable Hotspot Windows");
                    #endregion
                }
                return this.mUISetNetworkMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUIAboutMenuItem;
        
        private WinMenuItem mUIExitMenuItem;
        
        private WinMenuItem mUISetNetworkMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIAboutWindow : WinWindow
    {
        
        public UIAboutWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "About";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("About");
            #endregion
        }
        
        #region Properties
        public UICloseWindow UICloseWindow
        {
            get
            {
                if ((this.mUICloseWindow == null))
                {
                    this.mUICloseWindow = new UICloseWindow(this);
                }
                return this.mUICloseWindow;
            }
        }
        #endregion
        
        #region Fields
        private UICloseWindow mUICloseWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UICloseWindow : WinWindow
    {
        
        public UICloseWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "CloseButton";
            this.WindowTitles.Add("About");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("About");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIInformationWindow : WinWindow
    {
        
        public UIInformationWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Information";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Information");
            #endregion
        }
        
        #region Properties
        public UIYesWindow UIYesWindow
        {
            get
            {
                if ((this.mUIYesWindow == null))
                {
                    this.mUIYesWindow = new UIYesWindow(this);
                }
                return this.mUIYesWindow;
            }
        }
        
        public UIOKWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow(this);
                }
                return this.mUIOKWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIYesWindow mUIYesWindow;
        
        private UIOKWindow mUIOKWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIYesWindow : WinWindow
    {
        
        public UIYesWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "6";
            this.WindowTitles.Add("Information");
            #endregion
        }
        
        #region Properties
        public WinButton UIYesButton
        {
            get
            {
                if ((this.mUIYesButton == null))
                {
                    this.mUIYesButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIYesButton.SearchProperties[WinButton.PropertyNames.Name] = "Yes";
                    this.mUIYesButton.WindowTitles.Add("Information");
                    #endregion
                }
                return this.mUIYesButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIYesButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIOKWindow : WinWindow
    {
        
        public UIOKWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "2";
            this.WindowTitles.Add("Information");
            #endregion
        }
        
        #region Properties
        public WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOKButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                    this.mUIOKButton.WindowTitles.Add("Information");
                    #endregion
                }
                return this.mUIOKButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOKButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UISetHotspotWindow : WinWindow
    {
        
        public UISetHotspotWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Set Hotspot";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Set Hotspot");
            #endregion
        }
        
        #region Properties
        public UISSIDTextBoxWindow UISSIDTextBoxWindow
        {
            get
            {
                if ((this.mUISSIDTextBoxWindow == null))
                {
                    this.mUISSIDTextBoxWindow = new UISSIDTextBoxWindow(this);
                }
                return this.mUISSIDTextBoxWindow;
            }
        }
        
        public UIKeyTextBoxWindow UIKeyTextBoxWindow
        {
            get
            {
                if ((this.mUIKeyTextBoxWindow == null))
                {
                    this.mUIKeyTextBoxWindow = new UIKeyTextBoxWindow(this);
                }
                return this.mUIKeyTextBoxWindow;
            }
        }
        
        public UIShowPassButtonWindow1 UIShowPassButtonWindow
        {
            get
            {
                if ((this.mUIShowPassButtonWindow == null))
                {
                    this.mUIShowPassButtonWindow = new UIShowPassButtonWindow1(this);
                }
                return this.mUIShowPassButtonWindow;
            }
        }
        
        public UISetWindow UISetWindow
        {
            get
            {
                if ((this.mUISetWindow == null))
                {
                    this.mUISetWindow = new UISetWindow(this);
                }
                return this.mUISetWindow;
            }
        }
        
        public UIFromNetworkListComboWindow UIFromNetworkListComboWindow
        {
            get
            {
                if ((this.mUIFromNetworkListComboWindow == null))
                {
                    this.mUIFromNetworkListComboWindow = new UIFromNetworkListComboWindow(this);
                }
                return this.mUIFromNetworkListComboWindow;
            }
        }
        
        public UIToNetworkListComboBoWindow UIToNetworkListComboBoWindow
        {
            get
            {
                if ((this.mUIToNetworkListComboBoWindow == null))
                {
                    this.mUIToNetworkListComboBoWindow = new UIToNetworkListComboBoWindow(this);
                }
                return this.mUIToNetworkListComboBoWindow;
            }
        }
        
        public UIShareInternetWindow UIShareInternetWindow
        {
            get
            {
                if ((this.mUIShareInternetWindow == null))
                {
                    this.mUIShareInternetWindow = new UIShareInternetWindow(this);
                }
                return this.mUIShareInternetWindow;
            }
        }
        
        public UISetHotspotTitleBar UISetHotspotTitleBar
        {
            get
            {
                if ((this.mUISetHotspotTitleBar == null))
                {
                    this.mUISetHotspotTitleBar = new UISetHotspotTitleBar(this);
                }
                return this.mUISetHotspotTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UISSIDTextBoxWindow mUISSIDTextBoxWindow;
        
        private UIKeyTextBoxWindow mUIKeyTextBoxWindow;
        
        private UIShowPassButtonWindow1 mUIShowPassButtonWindow;
        
        private UISetWindow mUISetWindow;
        
        private UIFromNetworkListComboWindow mUIFromNetworkListComboWindow;
        
        private UIToNetworkListComboBoWindow mUIToNetworkListComboBoWindow;
        
        private UIShareInternetWindow mUIShareInternetWindow;
        
        private UISetHotspotTitleBar mUISetHotspotTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UISSIDTextBoxWindow : WinWindow
    {
        
        public UISSIDTextBoxWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "SSIDTextBox";
            this.WindowTitles.Add("Set Hotspot");
            #endregion
        }
        
        #region Properties
        public WinEdit UISSIDTextBoxEdit
        {
            get
            {
                if ((this.mUISSIDTextBoxEdit == null))
                {
                    this.mUISSIDTextBoxEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUISSIDTextBoxEdit.WindowTitles.Add("Set Hotspot");
                    #endregion
                }
                return this.mUISSIDTextBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUISSIDTextBoxEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIKeyTextBoxWindow : WinWindow
    {
        
        public UIKeyTextBoxWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "KeyTextBox";
            this.WindowTitles.Add("Set Hotspot");
            #endregion
        }
        
        #region Properties
        public WinEdit UIKeyTextBoxEdit
        {
            get
            {
                if ((this.mUIKeyTextBoxEdit == null))
                {
                    this.mUIKeyTextBoxEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIKeyTextBoxEdit.WindowTitles.Add("Set Hotspot");
                    #endregion
                }
                return this.mUIKeyTextBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIKeyTextBoxEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIShowPassButtonWindow1 : WinWindow
    {
        
        public UIShowPassButtonWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "ShowPassButton";
            this.WindowTitles.Add("Set Hotspot");
            #endregion
        }
        
        #region Properties
        public WinButton UITOButton
        {
            get
            {
                if ((this.mUITOButton == null))
                {
                    this.mUITOButton = new WinButton(this);
                    #region Search Criteria
                    this.mUITOButton.SearchProperties[WinButton.PropertyNames.Name] = "To";
                    this.mUITOButton.WindowTitles.Add("Set Hotspot");
                    #endregion
                }
                return this.mUITOButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUITOButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UISetWindow : WinWindow
    {
        
        public UISetWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "SetButton";
            this.WindowTitles.Add("Set Hotspot");
            #endregion
        }
        
        #region Properties
        public WinButton UISetButton
        {
            get
            {
                if ((this.mUISetButton == null))
                {
                    this.mUISetButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISetButton.SearchProperties[WinButton.PropertyNames.Name] = "Set";
                    this.mUISetButton.WindowTitles.Add("Set Hotspot");
                    #endregion
                }
                return this.mUISetButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISetButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIFromNetworkListComboWindow : WinWindow
    {
        
        public UIFromNetworkListComboWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "FromNetworkListComboBox";
            this.WindowTitles.Add("Set Hotspot");
            #endregion
        }
        
        #region Properties
        public WinButton UIOpenButton
        {
            get
            {
                if ((this.mUIOpenButton == null))
                {
                    this.mUIOpenButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOpenButton.SearchProperties[WinButton.PropertyNames.Name] = "Open";
                    this.mUIOpenButton.WindowTitles.Add("Set Hotspot");
                    #endregion
                }
                return this.mUIOpenButton;
            }
        }
        
        public WinComboBox UIFromNetworkListComboComboBox
        {
            get
            {
                if ((this.mUIFromNetworkListComboComboBox == null))
                {
                    this.mUIFromNetworkListComboComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUIFromNetworkListComboComboBox.WindowTitles.Add("Set Hotspot");
                    #endregion
                }
                return this.mUIFromNetworkListComboComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOpenButton;
        
        private WinComboBox mUIFromNetworkListComboComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIToNetworkListComboBoWindow : WinWindow
    {
        
        public UIToNetworkListComboBoWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "ToNetworkListComboBox";
            this.WindowTitles.Add("Set Hotspot");
            #endregion
        }
        
        #region Properties
        public WinButton UIOpenButton
        {
            get
            {
                if ((this.mUIOpenButton == null))
                {
                    this.mUIOpenButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOpenButton.SearchProperties[WinButton.PropertyNames.Name] = "Open";
                    this.mUIOpenButton.WindowTitles.Add("Set Hotspot");
                    #endregion
                }
                return this.mUIOpenButton;
            }
        }
        
        public WinComboBox UIToNetworkListComboBoComboBox
        {
            get
            {
                if ((this.mUIToNetworkListComboBoComboBox == null))
                {
                    this.mUIToNetworkListComboBoComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUIToNetworkListComboBoComboBox.WindowTitles.Add("Set Hotspot");
                    #endregion
                }
                return this.mUIToNetworkListComboBoComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOpenButton;
        
        private WinComboBox mUIToNetworkListComboBoComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIShareInternetWindow : WinWindow
    {
        
        public UIShareInternetWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "ShareInternetButton";
            this.WindowTitles.Add("Set Hotspot");
            #endregion
        }
        
        #region Properties
        public WinButton UIShareInternetButton
        {
            get
            {
                if ((this.mUIShareInternetButton == null))
                {
                    this.mUIShareInternetButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIShareInternetButton.SearchProperties[WinButton.PropertyNames.Name] = "Share Internet ";
                    this.mUIShareInternetButton.WindowTitles.Add("Set Hotspot");
                    #endregion
                }
                return this.mUIShareInternetButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIShareInternetButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UISetHotspotTitleBar : WinTitleBar
    {
        
        public UISetHotspotTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Set Hotspot");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Set Hotspot");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
}
