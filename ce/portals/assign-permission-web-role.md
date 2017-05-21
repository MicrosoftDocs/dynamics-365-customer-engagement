# Assign a permission set to a web role for portals

Applies To: Dynamics 365 (online), Dynamics CRM Online

Website Access Permissions is a permission set, associated with a web role, that permits front-side editing of the various content managed elements within the portal other than just webpages. The permission settings determine which components can be managed in the portal. More information: [Create web roles for portals](create-web-roles.md)  

| Name                         | Description                                                                                                                                                                                                           |
|------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Manage Content Snippets      | Allows the editing of Snippet controls. More information: [Customize content by using content snippets](customize-content-snippets.md)                                                                 |  
| Manage Site Markers          | Allows the editing of hyperlinks that use [sitemarkers](#sitemarkers)                                                                                                                                                 |  
| Manage Web Link Sets         | Allows the editing of web link sets, including adding and removing web links from a web link set. More information: [Manage web links in Dynamics 365 or on portals](manage-web-links.md) |  
| Preview Unpublished Entities | Allows the viewing of portal-exposed entities that have a publishing state of **Draft**.                                                                                                                              |

To add website access permission to a web role, just create a new Website Access entity, give it the permission set you want, name it, associate with the website in question, save, and then associate it with the web role(s) you desire.

### See Also

[Create web roles for portals](create-web-roles.md)  
[Control webpage access for portals](webpage-access-control.md)  
[Add record-based security using entity permissions for portals](assign-entity-permissions.md)  

