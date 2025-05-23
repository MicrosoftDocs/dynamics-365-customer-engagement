---
title: "Manage currencies in Dynamics 365 Customer Engagement (on-premises)"
description: "If your customers are spread across geographies, add their currencies to manage your transactions. You can also edit, disable, or delete currencies."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: how-to
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 0448166f-36a5-4f87-bb2a-a1904914c2ab
caps.latest.revision: 22
author: Mattp123
ms.author: matp
search.audienceType: 
  - admin
---
# Manage multiple currencies

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

Currencies determine the prices for products in the product catalog and the cost of transactions, such as sales orders. If your customers are spread across geographies, add their currencies in Dynamics 365 Customer Engagement (on-premises) to manage your transactions. Add the currencies that are most appropriate for your current and future business needs.  

## Add a currency  

1. Make sure you have the System Administrator security role or equivalent permissions.

    Check your security role  

   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  

   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  

2. [!INCLUDE[proc_settings_bus_management](../includes/proc-settings-bus-management.md)]  

3. Click **Currencies**.  

4. Click **New**.  

5. Fill in the information, as required.  


   |          Field          |                                                                                                                                                                                                                                                                                                                                                                            Description                                                                                                                                                                                                                                                                                                                                                                            |
   |-------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   |    **Currency Type**    | - **System** - Select this option if you want to use the currencies available in Customer Engagement (on-premises). To search for a currency,  click the **Lookup** button ![Lookup button.](../admin/media/lookup-button-4.gif "Lookup button") next to **Currency Code**. When you select a currency code, **Currency Name** and **Currency Symbol** are automatically added for the selected currency.<br />- **Custom** - Select this option if you want to add a currency that's not available in Customer Engagement (on-premises). In this case, you must manually enter the values for **Currency Code**, **Currency Precision**, **Currency Name**, **Currency Symbol**, and **Currency Conversion**. |
   |    **Currency Code**    |                                                                                                                                                                                                                                                                                                                                            Short form for the currency. For example, **USD** for United States Dollar.                                                                                                                                                                                                                                                                                                                                            |
   | **Currency Precision**  |                                                                                                                                                                                  Type the number of decimals that you want to use for the currency.  You can add a value between 0 and 4. **Note:**  If you’ve set a precision value in the **System Settings** dialog box, that value will appear here. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - General tab](../admin/system-settings-dialog-box-general-tab.md).                                                                                                                                                                                  |
   |    **Currency Name**    |                                                                                                                                                                                                                                         If you selected a currency code from the list of available currencies in Customer Engagement (on-premises), the currency name for the selected code is displayed here. If you selected **Custom** as the currency type, type the name of the currency.                                                                                                                                                                                                                                          |
   |   **Currency Symbol**   |                                                                                                                                                                                                                                                                      If you selected a currency code from the list of available currencies, the symbol for the selected currency is displayed here. If you selected **Custom** as the currency type, enter the symbol for the new currency.                                                                                                                                                                                                                                                                       |
   | **Currency Conversion** |                                                                                                                                                                                                                                     Type the value of the selected currency in terms of one US dollar. This is the amount at which the selected currency converts to the base currency. **Important:**  Make sure you update this value as frequently as required to avoid any inaccurate calculations in your transactions.                                                                                                                                                                                                                                      |


6. When you’re done, on the command bar, click **Save** or **Save and Close**.  

   > [!TIP]
   >  To edit a currency, click the currency, and then enter or select the new values.  

## Delete a currency  

1.  Click **Settings** > **Business Management**.  

2.  Click **Currencies**.  

3.  From the list of currencies displayed, select the currency to delete.  

4.  Click **Delete**  ![Delete button.](media/crm_ua_delete.gif "Delete button").  

5.  Confirm the deletion.  

> [!IMPORTANT]
>  You can’t delete currencies that are in use by other records; you can only deactivate them. Deactivating currency records doesn’t remove the currency information stored in existing records, such as opportunities or orders. However, you won’t be able to select the deactivated currency for new transactions.  

### See also  
 [System Settings dialog box - General tab](../admin/system-settings-dialog-box-general-tab.md)   


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
