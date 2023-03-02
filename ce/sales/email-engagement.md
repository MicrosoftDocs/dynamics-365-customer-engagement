---
title: Use email engagement to view message interactions
description: Use email engagement to view the message interactions such as, alerts, clicked a link, opened an attachment, or sent a reply on your emails.
ms.date: 02/27/2023
ms.topic: conceptual
author: udaykirang
ms.author: udag
manager: shujoshi
---
# Use email engagement to view message interactions 

Use email engagement to view the message interactions such as, alerts, clicked a link, opened an attachment, or sent a reply on your emails.

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## How does email engagement helps you sell better  

Email engagement helps you to:  
  
-   See when recipients opened your message, clicked a link, opened an attachment, or sent a reply.      
-   Receive an immediate alert when the recipient opens your message for the first time.      
-   Schedule the most effective delivery time, and receive advice for the best time based on the recipient's time zone.    
-   Choose the most effective message template, with recommendations based on your organization's previous email interaction history.      
-   Set an alert to remind you when it's time to follow up on an email message.       
-   Review the full interaction history of a single message, or review  KPIs.  
  
Your administrator must enable email engagement before you can try it out. Email engagement uses the relationship assistant to deliver alerts and other messages, so we strongly recommend that you also enable the assistant if you're using email engagement. For complete details about prerequisites, how to enable the feature, see [Enable email engagement](configure-email-engagement.md).

## Considerations for email tracking

Some aspects of the email engagement feature might be visible in [!INCLUDE[pn_sales_business_doc_name_shortest](../includes/pn-sales-business-doc-name-shortest.md)] even when the feature is turned off. These include:

-   The **Attachments** grid, which is shown when you author an email message or email template, always includes the **Followed** column.  
-   The **Followed Email** grid always shows **Opens**, **Last Opened Time**, **Attachment Views**, **Link Clicks**, and **Replies** columns.  
-   The **Email Template** grid always shows **Reply Rate**, **Open Rate**, **Recommended**, and **Email Count** columns.  
-   The out-of-the-box versions of the account, contact, and lead forms all include the **Follow Email** field.  

While the email engagement feature is disabled, these features will still appear but will usually be empty. Read the rest of this article for details about what these columns mean and how to use them when the feature is enabled.     

> [!NOTE]
> When the email client automatically scans email for security reasons, the count for email open and link clicks can be higher than expected.

### See also  

[Enable email engagement](configure-email-engagement.md)  
[Create and send email message](create-send-email-message.md)   
[Understand email history](understand-email-history.md)  
[Configure privacy and preferences](configure-individuals-privacy-preferences.md)
