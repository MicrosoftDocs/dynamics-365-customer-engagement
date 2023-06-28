---
title: "Search for records in Omnichannel for Customer Service | MicrosoftDocs"
description: "This article provides information on how to search for records and link a record to a conversation in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
monikerRange: '>= dynamics-usd-4.1'
---

# Search for records in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The topic explains how to search for records in Omnichannel for Customer Service.

## Search for records using the inline search option

You accept an incoming conversation request and there is no customer record identified in the Omnichannel for Customer Service. In this case, use the inline search option in the **Customer profile** form and **Issue snapshot** form to search for a contact or account and case respectively.

The inline search is based on Lookup View and Quick Find View. You can search the fields (attributes) that are based on Lookup View and Quick Find View.

For **Customer profile**, you can search for Contact or Account entity. By default, you can search using the following fields.

| Entity         | Fields  |
|---------       | ---------|
|  Account  |  <ul><li> Account Name</li> <li>Account Number</li><li>Email</li><li>Main Phone</li> |
| Contact | <ul><li> Company Name</li><li>Email</li><li> First Name </li><li> Last Name </li><li>Middle Name</li><li>Full Name</li><li>Mobile Phone</li> |

<!---
<table>
    <tr>
        <th>Entity</th>
        <th>Fields</th>
    </tr>
    <tr>
        <td rowspan="4">Account</td>
        <td>Account Name</td>
    </tr>
    <tr>
        <td>Account Number</td>
    </tr>
    <tr>
        <td>Email</td>
    </tr>
    <tr>
        <td>Main Phone</td>
    </tr>
    <tr>
        <td rowspan="7">Contact</td>
        <td>Company Name</td>
    </tr>
    <tr>
        <td>Email</td>
    </tr>
    <tr>
        <td>First Name</td>
    </tr>
    <tr>
        <td>Last Name</td>
    </tr>
    <tr>
        <td>Middle Name</td>
    </tr>
    <tr>
        <td>Full Name</td>
    </tr>
    <tr>
        <td>Mobile Phone</td>
    </tr>  
 </table>
--->
For the **Issue snapshot**, you can search for Case (Incident) entity. By default, you can search using the following fields.

| Entity         | Fields  |
|---------       | ---------|
|  Case  |  <ul><li> Case Number</li> <li>Case Title</li> |

<!---
<table>
<tr>
        <th>Entity</th>
        <th>Fields</th>
    </tr>
    <tr>
        <td rowspan="2">Case</td>
        <td>Case Number</td>
    </tr>
    <tr>
        <td>Case Title</td>
    </tr> 
 </table>
--->
Only active views are displayed for the search results. Also, you can customize the **Quick Find View** and **Lookup View** to change the searchable fields as per your business requirements.

More information: 
[Understand views](/dynamics365/customer-engagement/customize/create-edit-views)  
[Unified Interface Lookup view leverages Quick Find View](https://blogs.msdn.microsoft.com/crm/2018/11/02/unified-interface-lookup-now-leverages-quick-find-view/)  

To learn on how to link a record, see [Link a record to the conversation](link-unlink-record.md)

> [!div class="nextstepaction"]
> [Next topic: Link and unlink a record](link-unlink-record.md)

### See also

[View customer summary and know everything about customers](customer-summary.md)  
[View conversation and session forms in the model-driven apps](view-omnichannel-conversation-session.md)  
[View customer summary for an incoming conversation request](view-customer-summary-incoming-conversation-request.md)  
[Create a record](create-record.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
