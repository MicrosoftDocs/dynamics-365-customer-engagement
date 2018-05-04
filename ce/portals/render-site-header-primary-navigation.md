---
title: "Render a website header and primary navigation bar in a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions and sample code to render a website header and primary navigation bar on a portal."
ms.custom: dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: d6af4c8f-9164-4b18-9e1d-644293063fd9
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Render a website header and primary navigation bar

Render a website header and primary navigation bar, using portals settings, snippets, weblinks, and sitemarkers. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Store source content by using web templates](store-content-web-templates.md)  

> [!Note]
> The example in this topic will only function correctly if cross-request header caching is disabled for your application. It is enabled by default in version 7.0.0019 and later. It can be disabled by creating a Site Setting named Header/OutputCache/Enabled, and setting its value to false.


```
<divclass="masthead hidden-xs">
<divclass="container">
<divclass="toolbar">
<divclass="toolbar-row">
{%assignsearch_enabled=settings['search/enabled']|boolean|default:true%}{%assignsearch_page=sitemarkers['Search']%}{%ifsearch_enabledandsearch_page%}
<divclass="toolbar-item toolbar-search">
<formmethod="GET"action="{{search_page.url}}"role="search">
<labelfor="q"class="sr-only">
{{snippets["Header/Search/Label"]|default:"Search"}}
</label>
<divclass="input-group">
<inputtype="text"class="form-control"id="q"name="q"placeholder="{{snippets["Header/Search/Label"]|default:"Search"}}"value="{{params.q}}"title="{{snippets["Header/Search/Label"]|default:"Search"}}">
<divclass="input-group-btn">
<buttontype="submit"class="btn-default" title="{{snippets["Header/Search/ToolTip"]|default:"Search"}}">
<spanclass="fa-search" aria-hidden="true">
</span>
</button>
</div>
</div>
</form>
</div>
{%endif%}
<divclass="toolbar-item">
<divclass="btn-toolbar"role="toolbar">
{%ifuser%}
<divclass="btn-group">
<ahref="#"class="btn-default dropdown-toggle" data-toggle="dropdown">
<spanclass="fa fa-user"aria-hidden="true">
</span>
<spanclass="username">
{{user.fullname}}
</span>
<spanclass="caret">
</span>
</a>
<ulclass="dropdown-menu pull-right"role="menu">
{%assignshow_profile_nav=settings["Header/ShowAllProfileNavigationLinks"]|boolean|default:true%}{%ifshow_profile_nav%}{%assignprofile_nav=weblinks["Profile Navigation"]%}{%ifprofile_nav%}{%forlinkinprofile_nav.weblinks%}
<li>
<ahref="{{link.url}}">
{{link.name}}
</a>
</li>
{%endfor%}{%endif%}{%else%}
<li>
<ahref="{{sitemarkers['Profile'].url}}">
{{snippets["Profile Link Text"]|default:"Profile"}}
</a>
</li>
{%endif%}
<liclass="divider">
</li>
<li>
<ahref="/account-signout?returnUrl={{request.raw_url}}">
{{snippets["links/logout"]|default:"SignOut"}}
</a>
</li>
</ul>
</div>
{%else%}
<divclass="btn-group">
<aclass="btn btn-primary"href="{{sitemarkers['Login'].url|add_query:'returnurl',request.path_and_query}}">
<spanclass="fa-sign-in "aria-hidden="true">
</span>
{{snippets["links/login"]|default:"Sign In"}}
</a>
</div>
{%endif%}
</div>
</div>
</div>
</div>
{%editablesnippets'Header'type:'html'%}
</div>
</div>
<divclass="header-navbar navbar navbar-default navbar-static-top"role="navigation">
<divclass="container">
<divclass="navbar-header">
<buttontype="button"class="navbar-toggle"data-toggle="collapse"data-target="#header-navbar-collapse">
<spanclass="sr-only">
Toggle navigation
</span>
<spanclass="icon-bar">
</span>
<spanclass="icon-bar"></span><spanclass="icon-bar"></span></button><divclass="navbar-left visible-xs">
{%editablesnippets'Mobile Header'type:'html'%}
</div>
</div>
<divid="header-navbar-collapse"class="navbar-collapse">
<divclass="navbar-left hidden-xs">
{%editablesnippets'Navbar Left'type:'html'%}
</div>
{%assignprimary_nav=weblinks["Primary Navigation"]%}{%ifprimary_nav%}
<divclass="navbar-left {%ifprimary_nav.editable%}xrm-entity xrm-editable-adx_weblinkset{%endif%}"data-weblinks-maxdepth="2">
<ulclass="navbar-nav weblinks">
{%forlinkinprimary_nav.weblinks%}{%iflink.display_page_child_links%}{%assignsublinks=sitemap[link.url].children%}{%else%}{%assignsublinks=link.weblinks%}{%endif%}
<liclass="weblink {%ifsublinks.size>0%} dropdown{%endif%}">
<a{%ifsublinks.size>0%}href="#"class="dropdown-toggle"data-toggle="dropdown"{%else%}href="{{link.url}}"{%endif%}{%iflink.nofollow%}rel="nofollow"{%endif%}{%iflink.tooltip%}title="{{link.tooltip}}"{%endif%}>
{%iflink.image%}{%iflink.image.urlstartswith'.'%}
<spanclass="{{link.image.url|split:'.'|join}}"aria-hidden="true">
</span>
{%else%}
<imgsrc="{{link.image.url}}"alt="{{link.image.alternate_text|default:link.tooltip}}" {%iflink.image.width%}width="{{link.image.width}}"{%endif%}{%iflink.image.height%}height="{{link.image.height}}"{%endif%}/>
{%endif%}{%endif%}{%unlesslink.display_image_only%}{{link.name}}{%endunless%}{%ifsublinks.size>0%}
<spanclass="caret">
</span>
{%endif%}
</a>
{%ifsublinks.size>0%}
<ulclass="dropdown-menu"role="menu">
{%iflink.url%}
<li>
<ahref="{{link.url}}"{%iflink.nofollow%}rel="nofollow"{%endif%}{%iflink.tooltip%}title="{{link.tooltip}}"{%endif%}>
{{link.name}}
</a>
</li>
<liclass="divider">
</li>
{%endif%}{%forsublinkinsublinks%}
<li>
<ahref="{{sublink.url}}"{%ifsublink.nofollow%}rel="nofollow"{%endif%}{%ifsublink.tooltip%}title="{{link.tooltip}}"{%endif%}>
{{sublink.name|default:sublink.title}}
</a>
</li>
{%endfor%}
</ul>
{%endif%}
</li>
{%endfor%}
</ul>
{%editableprimary_nav%}
</div>
{%endif%}
<divclass="navbar-right hidden-xs">
{%editablesnippets'Navbar Right'type:'html'%}
</div>
</div>
</div>
</div>
```

### See also

[Create advanced templates for portals](create-advanced-templates.md)  
[Create a custom page template by using Liquid and a web template page template](create-custom-template.md)  
[Create a custom page template to render an RSS feed](render-rss-custom-page-template.md)  
[Render the entity list associated with the current page](render-entity-list-current-page.md)  
[Render up to three levels of page hierarchy by using hybrid navigation](hybrid-navigation-render-page-hierachy.md)  

