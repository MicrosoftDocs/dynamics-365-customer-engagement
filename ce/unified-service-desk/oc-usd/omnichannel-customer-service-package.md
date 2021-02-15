---
title: "Deploy Omnichannel for Customer Service package on Unified Service Desk | MicrosoftDocs"
description: "Learn how to deploy Unified Service Desk - Omnichannel for Customer Service package on a model-driven app."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 02/15/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
monikerRange: '>= dynamics-usd-4.1'
---

# Deploy Unified Service Desk - Omnichannel for Customer Service package

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Microsoft Dynamics 365 Package Deployer enables you to deploy the **Unified Service Desk – Omnichannel for Customer Service** package on a model-driven app.

## Download Unified Service Desk - Omnichannel for Customer Service packages

Download one of the following versions of the **OmnichannelUnifiedServiceDeskPackage.zip**, and save it on your computer.

- [Unified Service Desk - Omnichannel for Customer Service package 3.2](https://go.microsoft.com/fwlink/p/?linkid=2154961)
- [Unified Service Desk - Omnichannel for Customer Service package 3.1](https://go.microsoft.com/fwlink/p/?linkid=2147551)
- [Unified Service Desk - Omnichannel for Customer Service package 3.0](https://go.microsoft.com/fwlink/p/?linkid=2143446)
- [Unified Service Desk - Omnichannel for Customer Service package 2.3](https://go.microsoft.com/fwlink/p/?linkid=2141358)

When you extract the contents of the compressed file into a folder, the following items are listed:

- PackageDeployer.exe

- OmnichannelAddOnPackage

- OmnichannelDemoPackage

- OmnichannelUpgradePackage

- Assembly files

> [!Important]
>
> We recommend that you deploy the **Unified Service Desk - Omnichannel for Customer Service** package on a new organization; don't use your existing test or production organization for testing Omnichannel for Customer Service.

## Unified Service Desk – Omnichannel for Customer Service – Add-on

Use this sample package if you have an existing deployment of Unified Service Desk and want to start using Omnichannel for Customer Service with it. This package installs Unified Service Desk solutions with minimal configuration data for Omnichannel for Customer Service to work with an existing Unified Service Desk in the specified organization.

## Unified Service Desk – Omnichannel for Customer Service

Use this sample package if you want to start using a new Unified Service Desk environment with Omnichannel. This package installs Unified Service Desk solutions and Omnichannel-supported solutions (Web resources) that are required to work with Unified Service Desk in the specified organization. This package provides basic configuration data.

## Unified Service Desk - Omnichannel for Customer Service - Upgrade

Use this package if you've deployed any of the following packages, and want to upgrade to the latest version:

- **Unified Service Desk - Omnichannel for Customer Service - Add-on**
- **Unified Service Desk - Omnichannel for Customer Service** with customizations

The **Upgrade** package updates the Customization files and creates the newly introduced out-of-the-box hosted controls, events, and UII actions. 

> [!Note]
>
> - If you are using the **Unified Service Desk - Omnichannel for Customer Service** package with no customizations, then we recommend you not to upgrade. Instead, deploy the **Unified Service Desk - Omnichannel for Customer Service**.
> - The **Upgrade** package doesn't provide any additional configuration data, such as Windows Navigation Rules, Action Calls, and Entity Searches.

## Deploy package on Dynamics 365 Customer Service app

> [!Note]
> If you are using Omnichannel for Customer Service and want to upgrade to July 2019 Update, you must uninstall the solutions from the previous releases, and then run the package deployer to deploy the **Omnichannel for Customer Service – Add-On** or **Omnichannel for Customer Service** package. To learn more, see [Delete Unified Service Desk - Omnichannel for Customer Service package](omnichannel-customer-service-package.md#delete-unified-service-desk---omnichannel-for-customer-service-package).

### Deploy an Omnichannel for Customer Service package

1. Run the **PackageDeployer.exe** file.

2. On the connect page, provide authentication details to connect to the instance where you want to deploy the package. Information about the packages is displayed.

3. Select the **Unified Service Desk - Omnichannel for Customer Service - Add-On** or **Unified Service Desk - Omnichannel for Customer Service** to install on your instance. Review the information and choose **Next**.

4. Review the information on the **Ready to Install** page that displays the package name for deployment and name of the organization, and choose **Next**. The validation status of the package is displayed.

5. After the validation completes successfully, choose **Next**. The package deployment status is displayed. After deployment is successful, a confirmation message appears.

6. Select **Next**.

7. Review the name and information about the package on the **Installation Complete** page, and choose **Finish** to exit the Package Deployer tool.

To learn more, see [Deploy a sample Unified Service Desk package using Package Deployer](/dynamics365/unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer?view=dynamics-usd-4#deploy-a-sample-unified-service-desk-package-using-package-deployer).

## Upgrade Omnichannel for Customer Service package

1. Run the **PackageDeployer.exe** file.

2. On the connect screen, provide authentication details to connect to the instance where you want to upgrade the current package.

3. On the **Select the import package to use** page, choose **Unified Service Desk - Omnichannel for Customer Service - Upgrade**, and then select **Next**. The **Unified Service Desk - Omnichannel for Customer Service - Upgrade Setup Tool** page appears.

4. Review the information about the components that will be upgraded on the **Unified Service Desk - Omnichannel for Customer Service - Upgrade Setup Tool** page, and then select **Next**.

5. On the **Ready to Install** page, select **Next** to verify the components to upgrade.
On the **Reading Unified Service Desk - Omnichannel for Customer Service - Upgrade Installer Configuration** page, information about what will be upgraded is listed.

6. Select **Next** to begin the upgrade. The next page displays the package deployment status.
A confirmation message is displayed on successful deployment of the package.

7. Select **Next**.
The **Upgrade Complete** screen displays the name and information about the package that you upgraded. 

8. Review the information, and choose **Finish** to exit the Package Deployer tool.

## Delete Unified Service Desk - Omnichannel for Customer Service package

When you deploy an Omnichannel for Customer Service package in an organization, the following managed solutions are created:

- OmnichannelUnifiedServiceDeskSolution
- USDUnifiedInterfaceCustomization
- DynamicsUnifiedServiceDesk
- UiiForMicrosoftDynamicsCRM2011
 
    > [!Note]
    > If you have deployed the Omnichannel New Environment package, then **OmnichannelUnifiedServiceDeskSolution** might not be present in the list of solutions.

1. Sign in to the Dynamics 365 instance.  

2. On the nav bar, choose **Settings** > **Solutions**.  

3. On the Solutions page, select one of the solutions by selecting the check box, and then choose **Delete**. You are prompted to confirm uninstalling a managed solution. Choose **OK** to proceed. <br>
   - OmnichannelUnifiedServiceDeskSolution
   - USDUnifiedInterfaceCustomization
   - DynamicsUnifiedServiceDesk
   - UiiForMicrosoftDynamicsCRM2011

      > [!NOTE]
      > You must the delete the solutions in the following order:
      > 1. OmnichannelUnifiedServiceDeskSolution
      > 2. USDUnifiedInterfaceCustomization
      > 3. DynamicsUnifiedServiceDesk
      > 4. UiiForMicrosoftDynamicsCRM2011
      > 
      >  You must follow the order to remove the solutions because some of the components in the solution depend on the components in the other solution.

4. After the solution is removed, repeat the steps to delete the other solutions.

### See also

[Omnichannel for Customer Service on Unified Service Desk](omnichannel-customer-service-unified-service-desk.md)  
[Configure recommended settings for Unified Service Desk](configure-settings-unified-service-desk.md)  
