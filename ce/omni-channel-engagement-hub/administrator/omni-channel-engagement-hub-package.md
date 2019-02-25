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

> [!Note]
> Go to [Experience Dynamics 365](https://experience.dynamics.com) and select **Insider Program**. Sign in with you account. Choose **Omni-channel Engagement Hub - Preview** and join.

> [!Important]
> As Omni-channel Engagement Hub is in the preview, we recommend deploying the **Unified Service Desk - Omni-channel Engagement Hub - Preview** package on a new organization. We recommend not to use your existing organization (test or production) for testing Omni-channel Engagement Hub - Preview.

## Deploy package on Dynamics 365 for Customer Engagement instance

1. Download the **OmnichannelUnifiedServiceDeskPackage.zip** and save it on your computer. Extract the contents in to a folder.<br> The extracted contents contain the **PackageDeployer.exe**, **OmnichannelUSDPackage**, and assembly files.

2. Run the **PackageDeployer.exe** file. 

3. In the **Connect to Microsoft Dynamics 365 for Customer Engagement** screen, provide authentication details to connect to the Customer Engagement instance where you want to deploy the package.

4. The next screen displays information about the package that will be installed on your Customer Engagement instance. Review the information, and choose **Next**.

5. The **Ready to Install** screen displays the package name for deployment and name of the Customer Engagement organization. Review the information, and choose **Next**.

6. The next screen displays the validation status of the package. After the validation completes successfully, choose **Next**.

7. The next page displays the package deployment status. A confirmation message is displayed on successful deployment of the package. Select **Next**.

8. The **Installation Complete** screen displays the name and information about the package that you deployed. Review the information, and choose **Finish** to exit the Package Deployer tool.

To learn more, see [Deploy a sample Unified Service Desk package using Package Deployer](/dynamics365/customer-engagement/unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer?view=dynamics-usd-4#deploy-a-sample-unified-service-desk-package-using-package-deployer
).

## See also

- [Omni-channel Engagement Hub on Unified Service Desk](omni-channel-engagement-hub-unified-service-desk.md)
- [Configure recommended settings for Unified Service Desk](configure-settings-unified-service-desk.md)