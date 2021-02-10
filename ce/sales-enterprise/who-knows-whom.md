---
title: "Who Knows Whom in Dynamics 365 Sales Insights | MicrosoftDocs"
description: "how to get introduced to a lead in Dynamics 365 Sales Insights."
ms.date: 10/31/2018
ms.service: crm-online
ms.custom: 
ms.topic: article
ms.assetid: 905fac5d-c36d-4d64-bc9d-be59c535ac56
author: udag
ms.author: udag
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 
topic-status: Drafting
---

# How to get introduced to a lead 

As a sales representative, you will interact with leads whom you have never met or talked to and it can be difficult to turn these interactions into positive outcomes. To help in these situations, [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] provides a feature known as **Who Knows Whom**. This feature provides you with details such as names and email addresses of your colleagues who know the lead. With these details, you can contact your colleagues for help in getting introduced to a lead and increase the chances of a positive outcome during the interaction.

Who knows Whom relationships are calculated from the communication and collaboration patterns of users in your Microsoft Exchange environment. This data helps connect you to others users within your Microsoft Exchange environment that can help facilitate a connection. Contacts or leads that are external to your Microsoft Exchange organization can be queried for and, in some cases, users internal to your Microsoft Exchange organization can also be queried for. For example, this is possible if a user within your Microsoft Exchange organization has added the an internal user’s email address to their Microsoft Exchange address book.

Who Knows Whom is available in **Contact** and **Lead** forms. When you open a lead or contact and select the **Sales Insights** view, the **Who Knows Whom** tile is displayed.  

> [!NOTE]
> If you do not see the **Who Knows Whom** tile in the **Sales Insights** view of a contact or lead, contact your administrator to enable this feature. To learn more, see [Configure Who knows whom](configure-who-knows-whom.md).

> [!div class="mx-imgBorder"]
> ![Who Knows Whom widget](media/wkw-widget.png "Who knows whom widget")

1. **Contacts who know the lead.** These contacts are the people in your organization who have communicated with the lead through calls and emails. A maximum of five contacts are displayed for a lead. These contacts are displayed based on the most communication with the lead.

    > [!div class="mx-imgBorder"]
    > ![Who Knows Whom connections](media/wkw_connection.png "Who knows whom connections")

    When you select a contact, details of the contact are displayed along with the strength of connection to a lead.

    > [!div class="mx-imgBorder"]
    > ![Connection details](media/wkw_connectiondetails.png "Connection details")<br>
      1. Strength of the connection
      2. Contact details
  
    To get introduced to the lead, you can send an email to the selected contact without leaving the page you are on. Select **Get Introduced**. This opens an email with a default request to introduce the lead. Select **Send** to send the email. If you want to customize the email with more options, select **Open Email Form**.

    > [!div class="mx-imgBorder"]
    > ![Email with default message](media/wkw_mail_to_introduction.png "Email with default message")

2. **List view.** Select this to see the people in your company who know your lead. The contacts are displayed based on the connection strength. Connections whose strength is strong are displayed first, followed by other connection strengths. You can also select **Get Introduced** to send an email request for an introduction to the lead.

    > [!div class="mx-imgBorder"]
    > ![Connection details in list view](media/wkw_list_view.png "Connection details in list view")<br>

Let’s look at an example. Blaine Carmack is a sales representative who sells coffee makers. He has a new lead, Yvonne McKay, who owns Fourth Coffee and has opened a new store. Blaine wants to sell coffee machines to Yvonne, but he has not met or spoken to her. Before Blaine makes a call to Yvonne, he wants to know if any of his colleagues know her so that they could introduce him to increase the positive outcome of the call. Blaine performs the following steps:

1.	Open the Sales app and go to the **My Open Leads** view.
2.	Open the lead **Yvonne McKay** with the topic **New store opened this year - follow up**. <br>
    The summary of the lead displays.
3.	Select the **Lead:Sales Insights** view from the view dropdown.

    > [!div class="mx-imgBorder"]
    > ![Select Who Knows Whom view](media/wkw_select_view.png "Select who knows whom view")

    The **Who Knows Whom** tile is displayed as shown next.

    > [!div class="mx-imgBorder"]
    > ![Who Knows Whom view](media/who_knows_whom.png "Who knows whom view")

4.  Select each contact to view the details and verify the connection strength to increase the chances of an introduction to the lead. Here, Tricia Potter has a better chance to introduce Yvonne McKay because of her strong connection strength.

    > [!div class="mx-imgBorder"]
    > ![Connection information](media/wkw_connection.png "Connection information")

    Alternatively, select list view to verify the connection strengths.

5.	Select **Get Introduced** to send an email to Tricia requesting an introduction to Yvonne.

    > [!div class="mx-imgBorder"]
    > ![Email with default message](media/wkw_mail_to_introduction.png "Email with default message")
  
6.	Select **Send**.<br>
    The email is sent to Tricia to introduce Yvonne. 

### See also

[Configure who knows whom](configure-who-knows-whom.md)