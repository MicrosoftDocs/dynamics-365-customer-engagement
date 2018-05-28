---
title: "Crowdsource ideas on a portal in Dynamics 365 | MicrosoftDocs"
description: "Learn how to manage Forum Ideas, Idea Comments, and Idea Votes on a portal."
ms.custom: ""
ms.date: 05/28/2018
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 237054b6-4106-4d00-8016-e3921a4fcf46
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Crowdsource ideas
Learn how to manage Forum Ideas, Idea Comments, and Idea Votes.

## Manage idea forums in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]

[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] users can manage Idea Forum records under the Community tab, provided the portal customizations have been imported into your [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization.

> [!NOTE]
> The way in which many of the content/display-oriented attributes are rendered is controlled by the views created by the portal developer.

## Access permissions

- **Read** access to an idea forum can be restricted to certain web roles by using the Roles with Read Access relationship. This relationship specifies the web roles that have permission to see and participate in the idea forum. Any portal users associated with any of these roles will be granted access to the idea forum. See [Create web roles for portals](create-web-roles.md).  
- **Change** access to an idea forum is controlled through the Moderators relationship. There is currently no front-side moderation functionality built into the idea portal application.

## Idea Forum attributes and relationships

The table below explains the standard attributes and relationships of the Idea Forum entity.

| Name                   | Description                                                                                                                                                                                                                                                                                   |
|------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Title                  | The name of the idea forum.                                                                                                                                                                                                                                                                   |
| Website                | The website to which the idea forum belongs.                                                                                                                                                                                                                                                  |
| Partial URL            | The URL path segment used to build the portal URL of the idea forum.| 
Summary                | HTML content providing a description of the idea forum.                                                                                                                                                                                                                                       |
| Ideas                  | Relationship specifying all idea records associated with the idea forum.                                                                                                                                                                                                                      |
| New Idea Policy        | An option that specifies how new idea records should be handled in the idea forum.                                                                                                                                                                                                            |
| Comment Policy         | An option that specifies how comments on ideas should be handled in the idea forum.                                                                                                                                                                                                           |
| Voting Policy          | An option that specifies how votes on ideas should be handled in the idea forum.                                                                                                                                                                                                              |
| Voting Type            | The type of voting the idea forum will allow.                                                                                                                                                                                                                                                 |
| Votes Per Idea         | The number of votes a user is allowed for a single idea belonging to an idea forum. When Voting Type is Up or Down this value is set to 1.                                                                                                                                                    |
| Votes Per User         | The number of votes a user is allowed to use in an idea forum. If no value is set, users have unlimited votes within the idea forum.                                                                                                                                                          |
| Roles with Read Access | Relationship specifying the web roles that have permission to see and participate in the idea forum. Any portal users associated with any of these roles will be granted access to the idea forum.                                                                                            |
| Moderators             | Relationship specifying the web roles that have permission to moderate the idea forum. There is currently no front-side moderation functionality built into the idea portal application.|
||

## Manage ideas in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]

For [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] users, provided the portal customizations have been imported into your [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization, Idea records can be managed under the Community tab.

## Idea attributes and relationships

The table below explains the standard attributes and relationships of the Idea entity.



| Name                  | Description                                                                                                                                                                                                                                                                                   |
|-----------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Title                 | A descriptive title for the idea.                                                                                                                                                                                                                                                             |
| Idea Forum            | The idea forum to which the idea belongs.                                                                                                                                                                                                                                                     |
| Partial URL           | The URL path segment used to build the portal URL of the idea forum.<br> Partial URL values are used as URL path segments. As such, they should not contain illegal URL path characters, such as "?", "#", "!", "%". Since portals URLs are generated by joining together Partial URL values with slashes ("/"), they should also not generally contain slashes.<br>Recommended practice would be to restrict Partial URL values to letters, numbers, and hyphens or underscores. For example: "press-releases", "Users_Guide", "product1".|
| Published to Web      | Whether the idea is visible on the website.               |
| Copy                  | HTML content providing a description of the idea.                                                                                                                                                                                                                                             |
| Summary               | A shortened summary of the idea.                                                                                                                                                                                                                                                              |
| Author Name           | Text specifying the name of the user that submitted the idea.                                                                                                                                                                                                                                 |
| Author E-mail         | Text specifying the e-mail of the user that submitted the idea.                                                                                                                                                                                                                               |
| Author                | Relationship specifying which portal user is associated with the idea.                                                                                                                                                                                                                        |
| Submitted On          | The date and time that the idea was created.                                                                                                                                                                                                                                                  |
| Status Reason         | An option that specifies the current status of the idea. <ul><li>**New**:The idea is active and can be voted on.</li><li>**Accepted**: The idea has been accepted and can no longer be voted on. Users that voted for the idea – if limited – have their votes returned to them.</li><li>**Completed**:The idea has been implemented successfully and can no longer be voted on. Users that voted for the idea – if limited – have their votes returned to them.</li><li>**Rejected**:The idea will not be pursued and can no longer be voted on. Users that voted for the idea – if limited – have their votes returned to them.</li></ul>                                                    |
| Status Author         | Relationship specifying which portal user is associated with the idea's status and status comment.                                                                                                                                                                                            |
| Status Comment        | An optional comment for the idea's status reason. In other words, when it's planned to be implemented, why it has been rejected, etc.                                                                                                                                                         |
| Comment Policy        | An option that specifies how comments on the idea should be handled.<ul><li>**Inherit**: The comment policy of the parent idea forum will be used. This is the default setting.</li><li>**Open**: Submissions from all users, anonymous and authenticated, are allowed and displayed immediately.</li><li>**Open to Authenticated Users**: Only submissions from authenticated users are allowed and they are displayed immediately.</li><li>**Moderated**: Submissions from all users, anonymous or authenticated, are allowed. The submissions will not be displayed until a moderator approves them.</li><li>**Closed**: Existing submissions are displayed, but no new submissions are allowed.</li><li>**None**: User submissions are disabled. No submissions can be made or viewed.</li></ul>  |
| Votes Up              | The number of positive votes the idea has received.                                                                                                                                                                                                                                           |
| Votes Down            | The number of negative votes the idea has received.                                                                                                                                                                                                                                           |
| Vote Sum              | The number of positive votes minus the number of negative votes.                                                                                                                                                                                                                              |
| Total Number of Votes | The number of positive votes plus the number of negative votes.                                                                                                                                                                                                                               |
| Idea Comments         | Relationship specifying all comments associated with the idea.                                                                                                                                                                                                                                |
| Idea Votes            | Relationship specifying all votes associated with the idea. | 
||

> [!Note]  
> Partial URL values are used as URL path segments. As such, they should not contain illegal URL path characters, such as "?", "\#", "!", "%". Because portal URLs are generated by joining together Partial URL values with slashes ("/"), they should also not generally contain slashes.Recommended practice would be to restrict Partial URL values to letters, numbers, and hyphens or underscores. For example: "press-releases", "Users\_Guide", "product1".

## Manage idea comments in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]

For [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] users, provided the portal customizations have been imported into your [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization, Idea Comment records can be managed under the Community tab.

## Idea comment attributes and relationships

The table below explains the standard attributes and relationships of the Idea Comment entity.

| Name             | Description                                                               |
|------------------|---------------------------------------------------------------------------|
| Name             | A title for the idea comment.                                             |
| Idea             | The idea to which the comment belongs.                                    |
| Content          | The content of the comment in HTML format.                                |
| Published to Web | Whether the comment is visible on the website.                            |
| Author Name      | Text specifying the name of the user that submitted the comment.          |
| Author E-mail    | Text specifying the e-mail of the user that submitted the comment.        |
| Author           | Relationship specifying which portal user is associated with the comment. |
| Posted On        | The date and time that the comment was created.                           |
||
## Manage idea votes in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]

For [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] users, provided the portal customizations have been imported into your [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization, Idea Vote records can be managed under the Community tab.

## Idea vote attributes and relationships

The table below explains the standard attributes and relationships of the Idea Vote entity. 

| Name         | Description                                                            |
|--------------|------------------------------------------------------------------------|
| Value        | A whole number representing the value of the vote.                     |
| Name         | A title for the vote.                                                  |
| Idea         | The idea to which the vote belongs.                                    |
| Voter Name   | Text specifying the name of the user that submitted the vote.          |
| Voter E-mail | Text specifying the e-mail of the user that submitted the vote.        |
| Voter        | Relationship specifying which portal user is associated with the vote. |
| Submitted On | The date and time that the vote was created.                           |
||

### See also

[Manage forum threads](manage-forum-threads.md)  
[Create forum posts on the portal](create-forum-posts.md)  
[Moderate forums](moderate-forums.md)  
[Subscribe to alerts](subscribe-alerts.md)