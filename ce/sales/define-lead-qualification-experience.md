---
title: Define lead qualification experience in Dynamics 365 Sales
description: Give your salespeople the flexibility to choose which records to create—account, contact, or opportunity—when a lead is qualified.
ms.date: 05/15/2024
ms.topic: how-to
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-lead
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Define the lead qualification experience  

As an admin, you can customize the lead qualification experience to help sellers qualify leads more effectively. You can customize the following aspects of the lead qualification experience:

- Select who creates opportunities when leads are qualified - seller or automatically by the system.
- Allow sellers to create multiple opportunities when a lead is qualified.
- Modify the opportunity form that opens when a lead is qualified.
- Choose to let Copilot summarize the lead after it's qualified.

## License and role requirements

| Requirement type | You must have |
|:-----------------|:--------------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Define the experience using Sales Hub app

1. In the Sales Hub app, select the Change area icon :::image type="icon" source="media/change-area-icon.png" border="false"::: at the bottom of the site map, and then select **App Settings**.
2. Under **General Settings**, select **Lead + Opportunity management** > **Lead Qualification**.
   You'll see following options:
    - **Try the new lead qualification experience**: Turn on this setting to use the new lead qualification experience.  This setting lets you define the experience for each record type, allow creation of multiple opportunities, and so on. Turn it off to use the legacy experience.  
    
    - **Auto-create records for newly qualified leads**: This option is for the legacy experience. Turn on this setting to automatically create account, contact, and opportunity records when a lead is qualified. Turn it off if you want salespeople to choose which records to create when a lead is qualified.
      
    For information about the fields that are automatically mapped from the lead to other entities, see [Field mappings to other entities](#field-mappings-to-other-entities).

### Define the record creation experience for each record type

When you turn on **Try the new lead qualification experience**, you can define who creates the record&mdash;seller or Automatic&mdash;for each record type.  

- Select **Seller** if you want sellers to decide whether to create a record, use an existing record, or not create a record at all.
- Select **Automatic** if you want the system to create the record automatically. Sellers can review the records that will be created automatically.
    
In either case, if there's a matching record in the system based on the email ID and phone number, the duplicate detection rules are applied to prevent the creation of duplicate records. Sellers can choose to use the existing record or create a new one.

When you select **Automatic** for a record type, the following fields are used to identify the related record:
- **Account**: The email ID and phone number are used to identify the account record. If a matching account record is found, the lead is associated with that account. If no matching account record is found, a new account record is created with the value in the **Company Name** field.
- **Contact**: The email ID and phone number are used to identify the contact record. If a matching contact record is found, the lead is associated with that contact. If no matching contact record is found, a new contact record is created with the values in the **First Name** and **Last Name** fields.
   
### Customize opportunity creation experience

When you turn on **Try the new lead qualification experience**, you can customize the opportunity creation experience. You can allow sellers to create multiple opportunities when a lead is qualified, and modify the opportunity form that opens when a lead is qualified.

Under **Modify opportunity form**, select **Add or remove fields** to customize the opportunity form that opens when a lead is qualified. The quick create form opens in Power Apps for editing.

Select **Let seller create up to 5 opportunities from a newly qualified lead** to allow sellers to create multiple opportunities when a lead is qualified. In some cases, sellers may want to create multiple opportunities to track different sales deals from the same lead. Sellers can create up to 5 opportunities from a lead.

### Summarize the lead after it's qualified

When you turn on **Try the new lead qualification experience**, you can choose to let Copilot summarize the lead after it's qualified. Copilot summarizes the lead by extracting key information from the lead and creating a summary card. The summary card includes key information such as the lead's name, company name, email, phone number, and address, along with links to the account, contact, and opportunity records that were created. 
 
## Define the experience using legacy web client

If you aren't using the Sales Hub app, you can define the lead qualification experience by using the legacy web client.

1. In your app, select the **Settings** icon, and then select **Advanced Settings**.

   :::image type="content" source="media/advanced-settings-option.png" alt-text="Screenshot of Advanced Settings option on the Settings menu":::

   The **Business Management** page opens.
2. Select **Settings** > **Administration** > **System Settings**.
3. Select the **Sales** tab.
4. Under **Qualify lead experience**, set **Create Account, Contact, and Opportunity records by default upon qualifying a lead** to **No** to allow salespeople to choose which records to create when a lead is qualified. Set it to **Yes** to automatically create account, contact, and opportunity records when a lead is qualified.

## Field mappings to other entities

When a lead is qualified, values of some fields from leads are automatically mapped to the corresponding fields in accounts, contacts, and opportunities.

**Fields mapped to opportunity**

| Field name in lead | Field name in opportunity |
|:-------------------|:--------------------------|
| Topic | Topic |
| Contact | Contact |
| Account | Account |

**Fields mapped to account**

| Field name in lead | Field name in account |
|:-------------------|:----------------------|
| Company | Account name |
| Website | Website |
| Business Phone | Phone |
| Street 1 | Address 1: Street 1 |
| Street 2 | Address 1: Street 2 |
| Street 3 | Address 1: Street 3 |
| City | Address 1: City |
| State/Province | Address 1: State/Province |
| ZIP/Postal Code | Address 1: ZIP/Postal Code |
| Country/Region | Address 1: Country/Region |

**Fields mapped to contact**

| Field name in lead | Field name in contact |
|:-------------------|:----------------------|
| First name | First name |
| Last name | Last name |
| Job title | Job title |
| Business Phone | Phone |
| Mobile phone | Mobile phone |
| Email | Email |
| Street 1 | Address 1: Street 1 |
| Street 2 | Address 1: Street 2 |
| Street 3 | Address 1: Street 3 |
| City | Address 1: City |
| State/Province | Address 1: State/Province |
| ZIP/Postal Code | Address 1: ZIP/Postal Code |
| Country/Region | Address 1: Country/Region |

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also
[Qualify or convert leads](qualify-lead-convert-opportunity-sales.md)  
[Create or edit leads](create-edit-lead-sales.md)  
[Troubleshoot issues with lead qualification](/troubleshoot/dynamics-365/sales/troubleshoot-lead-qualification-issues-for-system-admin)

[!INCLUDE[footer-include](../includes/footer-banner.md)]