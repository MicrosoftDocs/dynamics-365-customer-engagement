---
title: "Install LinkedIn Sales Insight solution for accounts (Dynamics 365 Sales) | MicrosoftDocs"
description: "Install LinkedIn Sales Insight solution for accounts in Dynamics 365 Sales."
ms.date: 02/11/2020
ms.service: "dynamics-365-sales"
ms.custom: "dyn365-sales"
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Install or delete LinkedIn Sales Insights solution

> [!IMPORTANT]
> - The enhanced experience for LinkedIn Sales Insights solution is a preview feature. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> - [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

The LinkedIn Sales Insights (LSI) integration will import the latest company profile data such as, personas, number of employees, and company URL from LinkedIn Sales Insights product into a matched account automatically in Dynamics 365 to help keep your data up to date. Importing this info will reduce the manual effort required to match company profiles between the two products, enter the details in D365 Sales and frequently update data as LSI updates them.    
As an administrator, you can install LinkedIn Sales Insights and make it available for your sales teams to use. When installed, all the accounts that are available in your organization will display the **LinkedIn Sales Insights** tab in **Accounts** form. Those accounts that have a matching LinkedIn Sales Insights company profile will show data from LSI.

> [!div class="mx-imgBorder"]
> ![LinkedIn Sales Insights tab in accounts form](media/lsi-tab-account.png "LinkedIn Sales Insights tab in accounts form")

## Review the prerequisites    
Before you install LinkedIn Sales Insights review the following requirements:     
-	You have a **System Administrator** security role in Dynamics 365.
-	You have a [Microsoft Relationship Sales](https://dynamics.microsoft.com/sales/relationship-sales/) subscription for Dynamics 365.     
    -OR-     
    You'll need to sign up your team for **LinkedIn Sales Navigator Team** or **LinkedIn Sales Navigator Enterprise**. More information: [LinkedIn Sales Solutions](https://business.linkedin.com/sales-solutions).      

    >[!NOTE]
    >We recommend having a Microsoft Relationship Sales solution Plus license. To learn more, see the Dynamics 365 Sales section from the [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).   

-	You'll need to enable JavaScript in your browser.
-	You'll need to disable your pop-up blocker for the Dynamics 365 domain.
-	Enable CRM sync is enabled for your organization to use the LinkedIn Sales Insights. More information: [CRM Sync & Activity Writeback for Dynamics 365](https://business.linkedin.com/sales-solutions/sales-navigator-customer-hub/resources/ms-dynamics-sync-activity-writeback).   

## Install the solution     

1.	Go to the [LinkedIn Sales Insights for Dynamics 365](https://go.microsoft.com/fwlink/?linkid=2154471) page, and then select **Get it now**.    
2.	Read the terms and conditions, and then select **Continue**.    
3.	The Dynamics 365 marketplace opens.    
4.	Choose the organization from the **Organization to add the application to** list, select the check boxes for Microsoft and Dynamics 365 legal terms and privacy statements, and then select **Agree**.    
5.	On the **Manage your solutions** page, verify the status of the installation.    
6.	Verify that the installation is complete by following the steps in Validate the installation.     

## Validate the installation    

1.	In your app, select **Settings**, and then select **Advanced Settings**.    
2.	Go to **Settings** > **Customizations** > **Solutions**.    
3.	Verify that the **msdyn_linkedinsalesinsights** solution is installed in your organization.   

    > [!div class="mx-imgBorder"]
    > ![Validate LinkedIn Sales Insights solution installation](media/lsi-validate-installation.png "Validate LinkedIn Sales Insights solution installation")
 
## Uninstall the solution    

1.	In your app, select **Settings**, and then select **Advanced Settings**.
2.	Go to **Settings** > **Customizations** > **Solutions**.
3.	Select the **msdyn_linkedinsalesinsights** solution and then select **Delete**.
4.	A confirmation message appears, select **OK**.    
    The solution is removed from your organization.

### See also

[Understand the LinkedIn Sales Insights tab](understand-lsi-accounts-form.md)     
[LinkedIn Sales Insights for Dynamics 365 Sales - Installation Guide](https://www.linkedin.com/help/sales-navigator/answer/a419445)
