---
title: " Deploy Omni-channel Engagement Hub package on Unified Service Desk | MicrosoftDocs"
description: "learn how to deploy Unified Service Desk - Omni-channel Engagement Hub package on Dynamics 365 for Customer Engagement apps instance."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 03/07/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 69C527F6-E863-4D5E-9476-1936B6B79E35
ms.custom: 
---

# Deploy Unified Service Desk - Omni-channel Engagement Hub package

Microsoft Dynamics 365 Package Deployer enables you to deploy **Unified Service Desk - Omni-channel Engagement Hub - Preview** package on a Dynamics 365 for Customer Engagement instance.

To download the **Unified Service Desk - Omni-channel Engagement Hub - Preview** package and Dynamics 365 Package Deployer, you must join the Omni-channel Engagement Hub - Preview program.

Download the **OmnichannelUnifiedServiceDeskPackage.zip** and save it on your computer. Extract the contents in to a folder.<br> The extracted contents contain the  following:

- PackageDeployer.exe

- OmnichannelAddOnPackage

- OmnichannelDemoPackage

- Assembly files

> [!Note]
> Go to [Experience Dynamics 365](https://experience.dynamics.com) and select **Insider Program**. Sign in with you account. Choose **Omni-channel Engagement Hub - Preview** and join.

> [!Important]
> As Omni-channel Engagement Hub is in preview, we recommend deploying the **Unified Service Desk - Omni-channel Engagement Hub - Preview** package on a new organization. We recommend not to use your existing organization (test or production) for testing Omni-channel Engagement Hub - Preview.

## Unified Service Desk - Omni-channel Engagement Hub - Preview - Add-on

Use this sample package if you have an existing deployment of Unified Service Desk and want to start using Omni-channel Engagement Hub with it. This package installs Unified Service Desk solutions with minimal configuration data for Omni-channel Engagement Hub to work with an existing Unified Service Desk in the specified Customer Engagement organization.

## Unified Service Desk - Omni-channel Engagement Hub - Preview
    
Use this sample package if you want to start using a new Unified Service Desk environment with Omni-channel. This package installs Unified service desk solutions and Omni-channel supported solutions (Web resources) that are required to work with Unified Service Desk in the specified Customer Engagement organization. This package provides basic configuration data.

## Deploy package on Dynamics 365 for Customer Engagement instance

> [!Note]
> If you are already using Omni-channel Engagement Hub and want to upgrade to April 2019 Update, you must uninstall the solutions from the previous releases and then run the package deployer to deploy the **Omni-channel Engagement Hub - Preview - Add-On** or **Omni-channel Engagement Hub - Preview - Demo** package. To learn more, see [Uninstall the solutions](#delete-solutions).

### Delete solutions

When you deploy a Omni-channel Engagement Hub package in a Customer Engagement organization, following managed solutions are created:

  - OCSDSolution
  - USDUnifiedInterfaceCustomization
  - DynamicsUnifiedServiceDesk
  - UiiForMicrosoftDynamicsCRM2011
 
> [!Note]
> If you have deployed Omni-channel New Environment package, then **OCUSDSolution** might not be present in the list of solutions.
 
1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] apps.  

2. On the nav bar, Choose **Settings** > **Solutions**.  

4. On the Solutions page, select one of the solutions by selecting the check box, and then choose **Delete**. You are prompted to confirm uninstalling a managed solution. Choose **OK** to proceed. <br>
   - OCSDSolution
   - USDUnifiedInterfaceCustomization
   - DynamicsUnifiedServiceDesk
   - UiiForMicrosoftDynamicsCRM2011

   > [!NOTE]
   > You must the delete the solutions in the following order:
   > 1. OCSDSolution
   > 2. USDUnifiedInterfaceCustomization
   > 3. DynamicsUnifiedServiceDesk
   > 4. UiiForMicrosoftDynamicsCRM2011
   > 
   >  You must follow the order to remove the solutions as some of the components in the solution depend on the components in the other solution.

5. After the solution is removed, repeat the steps for the other solutions to delete them.

### Deploy a package

1. Run the **PackageDeployer.exe** file. 

2. In the **Connect to Microsoft Dynamics 365 for Customer Engagement** screen, provide authentication details to connect to the Customer Engagement instance where you want to deploy the package.

3. The next screen displays information about the packages. Select the **Unified Service Desk - Omni-channel Engagement Hub - Preview - Add-On** or **Unified Service Desk - Omni-channel Engagement Hub - Preview - Demo** to install on your Customer Engagement instance. Review the information, and choose **Next**.

4. The **Ready to Install** screen displays the package name for deployment and name of the Customer Engagement organization. Review the information, and choose **Next**.

5. The next screen displays the validation status of the package. After the validation completes successfully, choose **Next**.

6. The next page displays the package deployment status. A confirmation message is displayed on successful deployment of the package. Select **Next**.

7. The **Installation Complete** screen displays the name and information about the package that you deployed. Review the information, and choose **Finish** to exit the Package Deployer tool.

To learn more, see [Deploy a sample Unified Service Desk package using Package Deployer](/dynamics365/customer-engagement/unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer?view=dynamics-usd-4#deploy-a-sample-unified-service-desk-package-using-package-deployer
).

<!-- ### Upgrade a package 

1. Run the **PackageDeployer.exe** file.

2. In the **Connect to Microsoft Dynamics 365 for Customer Engagement** screen, provide authentication details to connect to the Customer Engagement instance where you want to upgrade the current package.

3. Under Select the import package to use, choose **Unified Service Desk - Omni-channel Engagement Hub - Preview - Upgrade**, and then select **Next**.

4. The **Unified Service Desk – Omni-channel Engagement Hub - Preview - Upgrade Setup Tool** page appears. Review the information about the components that will be upgraded, and then select **Next**.

5. On the **Ready to Install** page, click Next to verify the components to upgrade.

6. On the **Reading Unified Service Desk – Omni-channel Engagement Hub - Preview - Upgrade Installer Configuration** page, information about what will be upgraded is listed. Select **Next** to begin the upgrade.

7. The next page displays the package deployment status. A confirmation message is displayed on successful deployment of the package. Select **Next**.

8. The **Upgrade Complete** screen displays the name and information about the package that you upgraded. Review the information, and choose **Finish** to exit the Package Deployer tool. -->

## See also

- [Omni-channel Engagement Hub on Unified Service Desk](omni-channel-engagement-hub-unified-service-desk.md)
- [Configure recommended settings for Unified Service Desk](configure-settings-unified-service-desk.md)