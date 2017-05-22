---
title: "Control webpage access for a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: c031b08e-58c8-4bea-8a18-1151fe5d8bc6
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Control webpage access for portals

Applies To: Dynamics 365 (online), Dynamics CRM Online

Web page access control rules are rules that you create for your site to control both the publishing actions that a web role can perform across the pages of your website as well as to control what pages are visible by what web roles. The webpage access entity has the following attributes:

| Name        | Description                                                                                                                                                                                                                                                |
|-------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Name        | A descriptive name for the rule.                                                                                                                                                                                                                           |
| Website     | The website that this rule applies to; must match the website of the page to which this rule is applied. Filters Web Page.                                                                                                                                 |
| Web Page    | The Web Page that this rule applies to.                                                                                                                                                                                                                    
                                                                                                                                                                                                                                                              
  | ![image6](media/image6.png) **Note **                                                                                                                                                                                        |    
  |--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|  
  | The rule will affect not only the page but all child pages of the page, therefore making this attribute select the branch of the website to which the rule will apply. If a rule is applied to the home page, then it will apply to the entire Portal. |  |
| Right       | **Grant Change** or **Restrict Read**. See [Grant change](#_Grant_change) below.                                                                                                                                                                           |  
| Description | A description of the rule. Optional.                                                                                                                                                                                                                       |

After creating a new access control rule, associate it with a page, this will cause it to affect both the page you assign the rule to as well as all child pages in other words, the entire 'branch' of the website.

There are two type of access control rule: Grant Change and Restrict Read.

-   ### **Grant Change**

> Grant Change allows a user in a web role associated with the rule to publish content changes for this page and all child pages of this page. Grant Change takes precedence over restrict read. For example, you might have a "news" section of the site; which you want to be editable by users in the "news editor" web role. These users might not have access to the entire site, and certainly can't edit the entire site, but within this branch they have full content publishing authority. You would create a webpage access control rule called "grant news publishing to news editors".
>
> Next you would set the right to "grant change" and the webpage to the parent page of the entire "news" branch of your site.
>
> You would then assign this web role to any contacts you want to designate as news editors. Bear in mind one user can have many web roles.
>
> A Grant Change rule should always be present in any portal that you wish to enable front-side editing for. This rule will apply to the home page of the site, thus making it the default rule for the entire site. This rule will be associated with a web role that is to represent the administrative role for the site. Users that are to be given front-side content publishing rights will be assigned to this role.

-   ### **Restrict read**

> The restrict read rule is used to limit viewing of a page (and its child pages) and its content to specific users. Whereas grant change is a permissive rule (it grants the ability to do something to its users), restrict read is a restrictive rule in that it restricts an action to a limited set of users. For example, you might have a section of the site meant to be used by employees only. You might restrict read of this branch to only people in the "employee" web role. You would create a new rule called "restrict read to Employees only".
>
> You would then set the right to restrict read and the page to the page at the top of the branch which is to be read only by employees.

You would then associate this rule with the employee web role and then assign users to this role.

| ![image6](media/image6.png) **Note **                                                                                                                                                                                                                                                                                                                                             |  
|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| The root 'home' page of a website is a special node and must not have a restrict read rule applied to it. This will produce a runtime error. The security validation requires that all users must be able to read the root page of a website to validate contents within the site. The login, access denied, page not found, and error page are also special cases that also must be readable by all users. |

### See Also

[Create web roles for portals](create-web-roles.md)  
[Assign permission set to a web role for portals](assign-permission-web-role.md)  
[Add record-based security using entity permissions for portals](assign-entity-permissions.md)  

