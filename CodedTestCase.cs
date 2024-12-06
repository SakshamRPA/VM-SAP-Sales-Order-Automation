using SAPSalesOrderRPA.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.Api.Models;
using UiPath.Testing.Activities.Models;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace SAPSalesOrderRPA
{
    public class CodedTestCase : CodedWorkflow
    {
        [TestCase]
        public void Execute()
        {
            // Arrange
            Log("Test run started for CodedTestCase.");
using var screen1 = uiAutomation.Open(
                Descriptors.SAP_Logon_760_app.SAP_Logon_760, 
                openMode: NAppOpenMode.IfNotOpen, 
                interactionMode: NInteractionMode.HardwareEvents
            );

using var screen2 = uiAutomation.Open(
    Descriptors.SAP_Logon_760_app.SAP_Logon_760, 
    openMode: NAppOpenMode.IfNotOpen, 
    interactionMode: NInteractionMode.HardwareEvents
);
screen2.Click(
    Descriptors.SAP_Logon_760_app.SAP_Logon_760.S3X, 
    Options.Click(NClickType.Single, NMouseButton.Left).With(interactionMode: NChildInteractionMode.SameAsCard)
);
screen1.Click(
                Descriptors.SAP_Logon_760_app.SAP_Logon_760.Log_On__Enter, 
                Options.Click(NClickType.Single, NMouseButton.Left).With(interactionMode: NChildInteractionMode.SameAsCard)
            );

// Open the SAP login screen
            var sapLoginScreen = uiAutomation.Open(Descriptors.SAP_Logon_760_app.SAP);

            // Type into the User field
            sapLoginScreen.TypeInto(Descriptors.SAP_Logon_760_app.SAP.TextField_User_Name, "thirugnanas");

            // Type into the Password field
            sapLoginScreen.TypeInto(Descriptors.SAP_Logon_760_app.SAP.PasswordField_Password, "Yash@123456789");

            // Click the Continue (Enter) button
            sapLoginScreen.Click(Descriptors.SAP_Logon_760_app.SAP.Button_Enter);
            // Act
            // For accessing UI Elements from Object Repository, you can use the Descriptors class e.g:
            // var screen = uiAutomation.Open(Descriptors.MyApp.FirstScreen);
            // screen.Click(Descriptors.MyApp.FirstScreen.SettingsButton);

            // Assert
            // To start using activities, use IntelliSense (CTRL + Space) to discover the available services, e.g. testing.VerifyExpression(...).
        }
    }
}