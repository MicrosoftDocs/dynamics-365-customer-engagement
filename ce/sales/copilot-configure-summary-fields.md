---
title: Configure fields for generating summaries and recent changes
description: Learn how to configure fields for generating summaries and recent changes list in Copilot for leads, opportunities, and accounts.
ms.date: 08/02/2024
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom:
  - bap-template
---

# Configure fields for generating summaries and recent changes

By default, Copilot uses a set of predefined fields to generate [summaries](copilot-get-information.md), a list of [recent changes](copilot-ask-questions.md#get-recent-changes) for accounts, leads, and opportunities, and [prepare for meetings](copilot-stay-ahead.md#prepare-for-upcoming-sales-appointments). You can add other fields from lead, opportunity, account, and related tables to make the summaries and recent changes list more relevant for your business.

> [!IMPORTANT]
>
> - The Account summary feature is an early access feature. You can [opt in](/power-platform/admin/opt-in-early-access-updates) to use it for testing and adoption in your environments.
> - If you have not opted in for the early access preview features, you continue to see account summary as a public preview feature. However, the account summary feature public preview must be enabled.  

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

1. Select **Opportunities**, **Leads**, or **Accounts**. The following screenshot shows the **Opportunity** settings page. The **Lead** and **Account** settings page is similar.

    :::image type="content" source="media/copilot-summary-settings.svg" alt-text="Screenshot of the Opportunity settings page for record summaries in Copilot.":::

1. To choose fields for generating summaries, select the **Summary** tab. To choose fields for generating the recent changes list, select the **Recent changes** tab.

    The recent changes list is generated from the audit history. If the **Recent changes** tab isn't available, it means that auditing is turned off globally or for the table you selected (leads or opportunities). Select **Turn audit on** in the notification bar to turn on audit history for all the tables in the **Recent changes** tab.

    :::image type="content" source="media/turn-audit-on.svg" alt-text="Screenshot of the Recent changes tab when auditing isn't turned on for any of the tables in the Recent changes tab.":::

1. Select **Add fields**.

1. Select at least four fields, up to a maximum of 10.

    The **Save** button is disabled if you select fewer than 4 or more than 10 fields. If you added more than 10 fields, clear the checkbox, or select fields that you don't need and select **Delete**.

    In the **Recent changes** tab, when you add a field from a related table that doesn't have audit history turned on, **Turn audit on** appears in the notification bar. Select it to turn on auditing for the table. If you remove the field later, you need to [turn off audit history](/power-platform/admin/manage-dataverse-auditing#enable-or-disable-auditing-for-an-entity) for the table manually.

1. <a name="admin-opportunity-summary-widget"></a>For **Opportunities** only. To display the [opportunity summary widget](copilot-get-information.md#view-opportunity-summary-widget) within the opportunity form, in the **Opportunities settings** page, select the **Show opportunity summary as a widget in the form** option.  
    To add the opportunity widget to custom forms, see [Add the opportunity summary widget to custom forms](#add-the-opportunity-summary-widget-to-custom-forms).

1. For **Opportunities** and **Accounts** only. To customize the sections to display in the summary, select **Customize related info**.  

    - **Opportunities**:
        
        1. In the **Customize related info** dialog box, select the sections that you want to display in the **Opportunity summary** view for users to see. These sections are:
            - **Enriched key info**: Displays relevant insights from related records in the key info section.
            - **Product insights**: Displays insights about the products in the opportunity and fields such as product names, total amount, and budget are considered for insights.
            - **Quote insights**: Displays insights about the quotes in the opportunity and fields such as total number of quotes, most recent quote, and total amount are considered for insights.
            - **Competitor insights**: Displays insights about the competitors in the opportunity and fields such as competitor names,  strengths, and weaknesses are considered for insights.

           By default, all options are selected.  

        1. Select **Save**.

    - **Accounts**:  
        
        1. In the **Customize related info** dialog box, select the sections that you want to display in the **Account summary** view for users to see. These sections are:
            - **Enriched key info**: Displays relevant insights from related records in the key info section.
            - **Opportunities**: Displays all open opportunities for this account.
            - **Leads**: Displays all leads linked to this account.
            - **Cases**: Displays all open cases linked to this account. However, to display information in this section, Dynamics 365 Customer Service must be enabled in your environment.  

           By default, all options are selected.  

        1. Select **Save**.

1. Save your changes.

## Add the opportunity summary widget to custom forms

The opportunity summary widget includes an AI-generated summary of the opportunity record. This widget is available in the opportunity form by default. If you have a custom form, you can add the opportunity summary widget to it.

1. Sign in to the [Power Apps maker portal](https://make.powerapps.com).
1. From the site map, select **Tables** and open the table.
1. From the Data experience section, select **Forms**.
1. Open your custom form for which you want to add the opportunity summary widget.
1. On the command bar, select **Component** and then add the **1-column section** component to the form as a placeholder for the widget.
1. From the **Component** site map, select Display and then add the **Record summary** to the newly added column.  

    The opportunity summary widget is added to the form.

    >[!NOTE]
    >To hide the **New section** label, go to the **Properties** tab of the **New Section** settings pane, and then select **Hide label**.  

1. Save and publish the form.

## Grant audit access to your sellers

Copilot generates the list of recent changes for leads, opportunities, and accounts from the audit history. So, your sellers need access to the audit history and audit summary to view the recent changes.

1. Sign in to the [Power Platform admin center](https://admin.powerplatform.microsoft.com) and select your environment.

1. Select **Settings** > **Users + permissions** > **Security roles**.

1. Select the security role that's assigned to your sellers, and then select the **Miscellaneous Privileges** tab.

1. In the list below the tab, select **Show only unassigned privileges**.

1. Select **Organization** as the **Privilege Level** for the following privileges:

    - **View Audit History**
    - **View Audit Summary**

1. Select **Save + close**.
