---
title: Customize lead qualification experience
description: Learn how to customize the lead qualification experience so that sellers can easily qualify leads.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: how-to 
ms.collection: get-started
ms.date: 05/20/2024
ms.custom: bap-template 
ai-usage: ai-assisted
---

# Customize lead qualification experience

As an admin, you can customize the lead qualification experience to help sellers qualify leads more effectively. You can customize the following aspects of the lead qualification experience:

- Select who creates opportunities when leads are qualified - seller or automatically by the system.
- Allow sellers to create multiple opportunities when a lead is qualified.
- Modify the opportunity form that opens when a lead is qualified.
- Choose to let Copilot summarize the lead after it's qualified.


## Open lead qualification settings page

To customize the lead qualification experience, you need to open the lead qualification settings page in the Sales Hub app.

1. In the Sales Hub app, select the Change area ![Change area](media/change-area.png) and then select **App Settings**.
1. Under General Settings, select **Lead + opportunity management**.
1. Select **Lead qualification**.
1. Turn on **Try the new lead qualification experience**.
   :::image type="content" source="media/lead-qualify-settings.svg" alt-text="Screenshot of the Lead qualification settings page.":::

## Choose who creates related records when a lead is qualified

By default, when a lead is qualified, sellers select the related account, contact, and opportunity records that need to be created for the lead. You can customize this experience by selecting the records that need to be created automatically and those that need to be created by the seller. 

1. [Open lead qualification settings page](#open-lead-qualification-settings-page).
1. For each record type, select who creates the record - Seller or Automatic. 
    - Select **Seller** if you want sellers to decide whether to create a record, use an existing record, or not create a record at all.
    - Select **Automatic** if you want the system to create the record automatically. Sellers can review the records that will be created automatically.

In either case, if there's a matching record in the system based on the email ID and phone number, the duplicate detection rules are applied to prevent the creation of duplicate records. Sellers can choose to use the existing record or create a new one.
   
### Fied mapping used for automatic record creation

When you select **Automatic** for a record type, the following fields are used to identify the related record:

- **Account**: The email ID and phone number are used to identify the account record. If a matching account record is found, the lead is associated with that account. If no matching account record is found, a new account record is created with the value in the **Company Name** field.

