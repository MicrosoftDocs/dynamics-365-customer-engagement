---
title: "SLA table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the SLA table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# SLA table/entity reference (Microsoft Dynamics 365 Field Service)

Contains information about the tracked service-level KPIs for cases that belong to different customers.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service SLA table extends the [Microsoft Dynamics 365 SLA table](/dynamics365/developer/reference/entities/sla).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

Changes from [ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/sla#BKMK_ObjectTypeCode)

#### ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|1083|**Opportunity Line**|
|1085|**Quote Line**|
|1089|**Order Line**|
|10045|**Data Lake Folder**|
|10046|**Data Lake Folder Permission**|
|10047|**Data Lake Workspace**|
|10048|**Data Lake Workspace Permission**|
|10049|**Data Processing configuration**|
|10050|**Exported Excel**|
|10051|**RetainedData Excel**|
|10052|**Synapse Database**|
|10053|**Synapse Link External Table State**|
|10054|**Synapse Link Profile**|
|10055|**Synapse Link Profile Entity**|
|10056|**Synapse Link Profile Entity State**|
|10057|**Synapse Link Schedule**|
|10058|**Component Version**|
|10059|**Component Version Data Source**|
|10060|**Component Version (Internal)**|
|10061|**Git Branch**|
|10062|**Git Configuration Retrieval Data Source**|
|10063|**Git Organization**|
|10064|**Git Project**|
|10065|**Git Repository**|
|10066|**Source Control Branch Configuration**|
|10067|**Source Control Component**|
|10068|**Source Control Component Payload**|
|10069|**Source Control Configuration**|
|10070|**Staged Source Control Component**|
|10071|**DataflowRefreshHistory**|
|10072|**EntityRefreshHistory**|
|10073|**Shared Link Setting**|
|10074|**DelegatedAuthorization**|
|10076|**CascadeGrantRevokeAccessRecordsTracker**|
|10077|**CascadeGrantRevokeAccessVersionTracker**|
|10078|**RevokeInheritedAccessRecordsTracker**|
|10079|**TdsMetadata**|
|10080|**Model-Driven App Element**|
|10081|**Model-Driven App Component Node's Edge**|
|10082|**Model-Driven App Component Node**|
|10083|**Model-Driven App Setting**|
|10084|**Model-Driven App User Setting**|
|10085|**Organization Setting**|
|10086|**Setting Definition**|
|10087|**CanvasApp Extended Metadata**|
|10088|**Service Plan Mapping**|
|10089|**Service Plan Custom Control**|
|10091|**ApplicationUser**|
|10094|**OData v4 Data Source**|
|10095|**Workflow Binary**|
|10096|**Credential**|
|10097|**Desktop Flow Module**|
|10098|**Flow Capacity Assignment**|
|10099|**Flow Credential Application**|
|10100|**Flow Event**|
|10101|**Flow Machine**|
|10102|**Flow Machine Group**|
|10103|**Flow Machine Image**|
|10104|**Flow Machine Image Version**|
|10105|**Flow Machine Network**|
|10106|**ProcessStageParameter**|
|10107|**Work Queue**|
|10108|**Work Queue Item**|
|10109|**Desktop Flow Binary**|
|10110|**Flow Log**|
|10111|**Flow Run**|
|10112|**Action Approval Model**|
|10113|**Approval**|
|10114|**Approval Request**|
|10115|**Approval Response**|
|10116|**Approval Step**|
|10117|**Await All Action Approval Model**|
|10118|**Await All Approval Model**|
|10119|**Basic Approval Model Data**|
|10120|**Flow Approval**|
|10129|**Connection Reference**|
|10130|**DVFileSearch**|
|10131|**DVFileSearchAttribute**|
|10132|**DVFileSearchEntity**|
|10133|**DVTableSearch**|
|10134|**DVTableSearchAttribute**|
|10135|**DVTableSearchEntity**|
|10136|**AICopilot**|
|10137|**AIPluginAuth**|
|10138|**AI Plugin Conversation Starter**|
|10139|**AI Plugin Conversation Starter Mapping**|
|10140|**AI Plugin Governance**|
|10141|**AI Plugin Governance Extended**|
|10142|**AIPluginOperationResponseTemplate**|
|10143|**AIPluginTitle**|
|10144|**SideloadedAIPlugin**|
|10145|**AIPlugin**|
|10146|**AIPluginExternalSchema**|
|10147|**AIPluginExternalSchemaProperty**|
|10148|**AIPluginInstance**|
|10149|**AIPluginOperation**|
|10150|**AIPluginOperationParameter**|
|10151|**AIPluginUserSetting**|
|10153|**AI Event**|
|10154|**AI Builder Feedback Loop**|
|10155|**AI Form Processing Document**|
|10156|**AI Object Detection Image**|
|10157|**AI Object Detection Label**|
|10158|**AI Object Detection Bounding Box**|
|10159|**AI Object Detection Image Mapping**|
|10161|**AI Builder Dataset**|
|10162|**AI Builder Dataset File**|
|10163|**AI Builder Dataset Record**|
|10164|**AI Builder Datasets Container**|
|10165|**AI Builder File**|
|10166|**AI Builder File Attached Data**|
|10167|**Help Page**|
|10168|**Tour**|
|10169|**BotContent**|
|10170|**ConversationTranscript**|
|10171|**Copilot**|
|10172|**Copilot component**|
|10173|**Copilot component collection**|
|10184|**Comment**|
|10185|**Governance Configuration**|
|10186|**Fabric AISkill**|
|10187|**App Insights Metadata**|
|10188|**Dataflow Connection Reference**|
|10189|**Schedule**|
|10190|**Dataflow Template**|
|10191|**Dataflow DatalakeFolder**|
|10192|**Data Movement Service Request**|
|10193|**Data Movement Service Request Status**|
|10194|**DMS Sync Request**|
|10195|**DMS Sync Status**|
|10196|**Knowledge Asset Configuration**|
|10197|**Module Run Detail**|
|10198|**QnA**|
|10199|**Salesforce Structured Object**|
|10200|**Salesforce Structured QnA Config**|
|10201|**Workflow Action Status**|
|10202|**FederatedKnowledgeConfiguration**|
|10203|**FederatedKnowledgeEntityConfiguration**|
|10204|**Form Mapping**|
|10205|**Copilot Interactions**|
|10206|**PDF Setting**|
|10207|**Activity File Attachment**|
|10208|**Teams chat**|
|10209|**Service Configuration**|
|10210|**SLA KPI**|
|10211|**Integrated search provider**|
|10212|**Knowledge Management Setting**|
|10213|**Knowledge Federated Article**|
|10214|**Knowledge Federated Article Incident**|
|10215|**Search provider**|
|10216|**Knowledge Article Image**|
|10217|**Knowledge Configuration**|
|10218|**Knowledge Interaction Insight**|
|10219|**Knowledge Search Insight**|
|10220|**Favorite knowledge article**|
|10221|**Knowledge article language setting**|
|10222|**Knowledge Article Attachment**|
|10223|**Knowledge personalization**|
|10224|**Knowledge Article Template**|
|10225|**Knowledge search personal filter config**|
|10226|**Knowledge search filter**|
|10228|**SupportUserTable**|
|10229|**FxExpression**|
|10230|**Function**|
|10231|**Plug-in**|
|10232|**PowerfxRule**|
|10233|**Planner Business Scenario**|
|10234|**Planner Sync Action**|
|10235|**Ms Graph Resource To Subscription**|
|10236|**Virtual Entity  Metadata**|
|10237|**Background Operation**|
|10238|**Report Parameter**|
|10239|**MobileOfflineProfileExtension**|
|10240|**MobileOfflineProfileItemFilter**|
|10241|**TeamMobileOfflineProfileMembership**|
|10242|**UserMobileOfflineProfileMembership**|
|10243|**OrganizationDataSyncSubscription**|
|10244|**OrganizationDataSyncSubscriptionEntity**|
|10245|**OrganizationDataSyncSubscriptionFnoTable**|
|10246|**OrganizationDataSyncFnoState**|
|10247|**OrganizationDataSyncState**|
|10248|**ArchiveCleanupInfo**|
|10249|**ArchiveCleanupOperation**|
|10250|**BulkArchiveConfig**|
|10251|**BulkArchiveFailureDetail**|
|10252|**BulkArchiveOperation**|
|10253|**BulkArchiveOperationDetail**|
|10254|**EnableArchivalRequest**|
|10255|**MetadataForArchival**|
|10256|**ReconciliationEntityInfo**|
|10257|**ReconciliationEntityStepInfo**|
|10258|**ReconciliationInfo**|
|10259|**RetentionCleanupInfo**|
|10260|**RetentionCleanupOperation**|
|10261|**RetentionConfig**|
|10262|**RetentionFailureDetail**|
|10263|**RetentionOperation**|
|10264|**RetentionOperationDetail**|
|10265|**RetentionSuccessDetail**|
|10266|**CertificateCredential**|
|10267|**Notification**|
|10268|**User Rating**|
|10269|**Mobile App**|
|10270|**Insights Store Data Source**|
|10271|**Insights Store Virtual Entity**|
|10272|**RoleEditorLayout**|
|10273|**Deleted Record Reference**|
|10274|**Restore Deleted Records Configuration**|
|10275|**App Action**|
|10276|**App Action Migration**|
|10277|**App Action Rule**|
|10280|**Card**|
|10281|**Card State Item**|
|10284|**Entity link chat configuration**|
|10285|**SharePoint Managed Identity**|
|10286|**AI Insight Card**|
|10287|**AI Skill Config**|
|10288|**Rich Text Attachment**|
|10289|**Custom Control Extended Setting**|
|10290|**Timeline Pin**|
|10291|**Virtual Connector Data Source**|
|10292|**Virtual Table Column Candidate**|
|10294|**PM Analysis History**|
|10295|**PM Business Rule Automation Config**|
|10296|**PM Calendar**|
|10297|**PM Calendar Version**|
|10298|**PM Inferred Task**|
|10299|**PM Process Extended Metadata Version**|
|10300|**PM Process Template**|
|10301|**PM Process User Settings**|
|10302|**PM Process Version**|
|10303|**PM Recording**|
|10304|**PM Simulation**|
|10305|**PM Template**|
|10306|**PM View**|
|10307|**Analysis Component**|
|10308|**Analysis Job**|
|10309|**Analysis Override**|
|10310|**Analysis Result**|
|10311|**Analysis Result Detail**|
|10312|**Solution Health Rule**|
|10313|**Solution Health Rule Argument**|
|10314|**Solution Health Rule Set**|
|10315|**Power BI Dataset**|
|10316|**powerbidatasetapdx**|
|10317|**Power BI Mashup Parameter**|
|10318|**Power BI Report**|
|10319|**powerbireportapdx**|
|10320|**File Upload**|
|10321|**MainFewShot**|
|10322|**MakerFewShot**|
|10323|**SearchAttributeSettings**|
|10324|**SearchCustomAnalyzer**|
|10325|**SearchRelationshipSettings**|
|10326|**SearchResultsCache**|
|10327|**Search Telemetry**|
|10328|**ViewAsExampleQuestion**|
|10329|**CopilotExampleQuestion**|
|10330|**CopilotGlossaryTerm**|
|10331|**CopilotSynonyms**|
|10332|**Site Component**|
|10333|**Site**|
|10334|**Site Language**|
|10335|**Power Pages Site Published**|
|10338|**External Identity**|
|10339|**Invitation**|
|10340|**Invite Redemption**|
|10341|**Portal Comment**|
|10342|**Setting**|
|10343|**Multistep Form Session**|
|10347|**Ad Placement**|
|10348|**Column Permission**|
|10349|**Column Permission Profile**|
|10350|**Content Snippet**|
|10351|**Basic Form**|
|10352|**Basic Form Metadata**|
|10353|**List**|
|10354|**Table Permission**|
|10355|**Page Template**|
|10356|**Poll Placement**|
|10357|**Power Pages Core Entity DS**|
|10358|**Publishing State**|
|10359|**Publishing State Transition Rule**|
|10360|**Redirect**|
|10361|**Shortcut**|
|10362|**Site Marker**|
|10363|**Site Setting**|
|10364|**Web File**|
|10365|**Multistep Form**|
|10366|**Multistep Form Metadata**|
|10367|**Form Step**|
|10368|**Web Link**|
|10369|**Web Link Set**|
|10370|**Web Page**|
|10371|**Web Page Access Control Rule**|
|10372|**Web Role**|
|10373|**Website**|
|10374|**Website Access**|
|10375|**Website Language**|
|10376|**Web Template**|
|10383|**Power Pages Scan Report**|
|10384|**Power Pages Log**|
|10385|**PowerPagesManagedIdentity**|
|10386|**Power Pages Site AI Feedback**|
|10391|**Catalog Submission Files**|
|10392|**Package Submission Store**|
|10393|**Processor Registration**|
|10394|**signal**|
|10395|**Signal Registration**|
|10396|**trait**|
|10397|**Trait Registration**|
|10398|**List Operation**|
|10399|**Marketing Form Display Attributes**|
|10400|**Database Version**|
|10401|**Upgrade Run**|
|10402|**Upgrade Step**|
|10403|**Upgrade Version**|
|10404|**Activity monitor**|
|10405|**Originating Queue Mapping**|
|10406|**Unified Routing Setup Tracker**|
|10407|**Available Times**|
|10408|**Available Times Data Source**|
|10409|**resource group data source**|
|10410|**Virtual Resource Group Resource**|
|10411|**Migration tracker**|
|10412|**Asset Category Template Association**|
|10413|**Asset Template Association**|
|10414|**Customer Asset**|
|10417|**Customer Asset Attachment**|
|10418|**Customer Asset Category**|
|10419|**Functional Location**|
|10420|**Functional Location Type**|
|10421|**Location Template Association**|
|10422|**Functional Location Type Template Association**|
|10423|**Property Definition**|
|10424|**Property Asset Association**|
|10425|**Property Location Association**|
|10426|**Property Log**|
|10427|**Property Template Association**|
|10428|**Template For Properties**|
|10429|**Warranty**|
|10436|**IoT Alert**|
|10437|**IoT Device**|
|10438|**IoT Device Category**|
|10439|**IoT Device Command**|
|10440|**IoT Device Command Definition**|
|10441|**IoT Device Data History**|
|10442|**IoT Device Property**|
|10443|**IoT Device Registration History**|
|10444|**IoT Device Visualization Configuration**|
|10445|**IoT Field Mapping**|
|10446|**IoT Property Definition**|
|10447|**IoT Provider**|
|10448|**IoT Provider Instance**|
|10449|**IoT Settings**|
|10452|**IoT Alert to Case Process**|
|10454|**Playbook Callable Context**|
|10455|**Playbook activity**|
|10456|**Playbook activity attribute**|
|10457|**[DEPRECATED] Playbook category**|
|10458|**Playbook**|
|10459|**[DEPRECATED] Playbook template**|
|10461|**admin_settings_entity**|
|10462|**Collab Space Team Association**|
|10463|**CRM Connection**|
|10464|**External CRM**|
|10465|**External Record**|
|10466|**Tagged Record**|
|10467|**Copilot for Sales customer list**|
|10468|**msdyn_vivaentitysetting**|
|10469|**msdyn_vivaorgextensioncred**|
|10470|**msdyn_vivaorgsetting**|
|10471|**msdyn_vivausersetting**|
|10472|**Sales Copilot Insight**|
|10473|**Org level settings for Sales Copilot apps**|
|10474|**Sales Copilot User Setting**|
|10475|**App profile**|
|10476|**Application Extension**|
|10477|**Application Tab Template**|
|10478|**App profile role mapping**|
|10479|**Notification Field**|
|10480|**Notification Template**|
|10481|**Session Template**|
|10482|**Template Parameter**|
|10488|**Channel Integration Framework v1.0 Provider**|
|10489|**Notification Field (Deprecated)**|
|10490|**Notification Template (Deprecated)**|
|10491|**App Parameter Definition (Deprecated)**|
|10492|**Session Templates (Deprecated)**|
|10493|**Application Tab Template (Deprecated)**|
|10494|**Parameter (Deprecated)**|
|10495|**Template Tag (Deprecated)**|
|10496|**Application Type (Deprecated)**|
|10505|**Channel Integration Framework v2.0 Provider**|
|10507|**Conversation Data (Deprecated)**|
|10508|**KPI Event Data**|
|10509|**KPI Event Definition**|
|10510|**Session Data (Deprecated)**|
|10511|**Session Participant Data (Deprecated)**|
|10512|**Channel Definition**|
|10513|**Channel Definition Consent**|
|10514|**Channel Definition Locale**|
|10515|**Channel Instance**|
|10516|**Channel Instance Account**|
|10517|**Channel Message Attachment**|
|10518|**Channel Message Context Part**|
|10519|**Channel Message Part**|
|10520|**Consuming Application**|
|10521|**msdyn_DefExtendedChannelInstance**|
|10522|**msdyn_DefExtendedChannelInstanceAccount**|
|10523|**Productivity pane configuration**|
|10524|**Pane tab configuration**|
|10525|**Pane tool configuration**|
|10527|**Agent script**|
|10528|**Agent script step**|
|10530|**Action Input Parameter**|
|10531|**Action Output Parameter**|
|10532|**Macro Action Template**|
|10533|**Macro Solution Configuration**|
|10534|**Macro Connector**|
|10535|**Macro Run History**|
|10536|**Parameter definition**|
|10539|**Adaptive Card Configuration**|
|10540|**Smartassist configuration**|
|10542|**Read Tracker**|
|10543|**Read tracking enabled information**|
|10544|**Microsoft Teams Graph resource Entity**|
|10545|**msdyn_msteamssetting**|
|10546|**msdyn_msteamssettingsv2**|
|10547|**Microsoft Teams Collaboration entity**|
|10548|**Teams Dialer Admin settings**|
|10549|**Teams Contact Suggestion by AI**|
|10550|**Contact suggestion rule**|
|10551|**Contact suggestion ruleset**|
|10552|**Microsoft Teams chat association entity**|
|10553|**Microsoft Teams chat suggestion**|
|10554|**Microsoft Orgchart node entity**|
|10555|**Forecast Manual Adjustment History**|
|10556|**Distributed Lock**|
|10557|**Entity Delta Change**|
|10558|**File Upload Status Tracker**|
|10559|**Forecast**|
|10560|**Forecast Configuration**|
|10561|**Forecast definition**|
|10562|**Forecasting Cache**|
|10563|**Forecast Insights**|
|10564|**Forecast**|
|10565|**Forecast Prediction Data**|
|10566|**Forecast Prediction Status**|
|10567|**Forecast recurrence**|
|10568|**Recompute Tracker**|
|10569|**Forecast Recurrence**|
|10570|**ShareAs Configuration**|
|10571|**Customer email communication**|
|10572|**GDPRData**|
|10573|**ODOSFeatureMetadata**|
|10574|**ODOSMetadata**|
|10575|**Recurring Sales Action**|
|10576|**Recurring Sales Action V2**|
|10577|**msdyn_relationshipinsightsunifiedconfig**|
|10578|**siconfig**|
|10579|**SI Key Value Config**|
|10580|**Usage Metric**|
|10581|**Action Card Regarding**|
|10582|**Action Card Role Setting**|
|10583|**EntityRankingRule**|
|10584|**flowcardtype**|
|10585|**salesinsightssettings**|
|10586|**Action Card Usage**|
|10587|**Action Card Usage Aggregation**|
|10588|**Auto Capture Rule**|
|10589|**Auto Capture Settings**|
|10590|**UntrackedAppointment**|
|10591|**Suggested Activity**|
|10592|**Suggested Activity Data Source**|
|10593|**Suggested Contact**|
|10594|**Suggested Contacts Data Source**|
|10595|**Notes analysis Config**|
|10596|**icebreakersconfig**|
|10597|**dealmanageraccess**|
|10598|**Deal manager settings**|
|10599|**Account KPI Item**|
|10600|**Activity Analysis CleanUp State**|
|10601|**Relationship Analytics Config**|
|10602|**Contact KPI Item**|
|10603|**Daily Kpis for account**|
|10604|**Daily kpis for contact**|
|10605|**Daily kpis for lead**|
|10606|**Daily kpis for Opportunity**|
|10607|**Lead KPI Item**|
|10608|**Most Contacted**|
|10609|**Most Contacted By**|
|10610|**Opportunity KPI Item**|
|10611|**Relationship Analytics Metadata**|
|10612|**Similar entities feature importance**|
|10613|**wkwcolleaguesforcompany**|
|10614|**wkwcolleaguesforcontact**|
|10615|**wkwconfig**|
|10616|**Attribute Influence Statistics**|
|10617|**Prediction Computation Operation**|
|10618|**Prediction Model Status**|
|10619|**Prediction Scheduled Operation**|
|10620|**Predictive Model Score**|
|10621|**Predictive Score**|
|10622|**Predictive Scoring Sync Status**|
|10623|**Real Time Scoring**|
|10624|**Real Time Scoring Operation**|
|10625|**Submodel Definition**|
|10626|**Time spent in BPF**|
|10627|**Training Result**|
|10628|**OpportunityModelConfig**|
|10629|**LeadModelConfig**|
|10630|**ModelPreviewStatus**|
|10631|**Profile Album**|
|10632|**Post Configuration**|
|10633|**Post Rule Configuration**|
|10634|**Wall View**|
|10635|**Filter**|
|10636|**Customer Voice alert**|
|10637|**Customer Voice alert rule**|
|10638|**Customer Voice survey email template**|
|10639|**Customer Voice file response**|
|10640|**Customer Voice localized survey email template**|
|10641|**Customer Voice project**|
|10642|**Customer Voice survey question**|
|10643|**Customer Voice survey question response**|
|10644|**Customer Voice satisfaction metric**|
|10645|**Customer Voice survey**|
|10646|**Customer Voice survey invite**|
|10647|**Customer Voice survey reminder**|
|10648|**Customer Voice survey response**|
|10649|**Customer Voice unsubscribed recipient**|
|10650|**Customer Service Key Value Configuration**|
|10651|**AddToCalendar style**|
|10652|**basestyle**|
|10653|**Button style**|
|10654|**Code style**|
|10655|**Column style**|
|10656|**Content Block**|
|10657|**Divider style**|
|10658|**General styles**|
|10659|**imagestyle**|
|10660|**Layout Style**|
|10661|**QR code style**|
|10662|**Text style**|
|10663|**Video style**|
|10664|**App state**|
|10665|**CSAdminConfig**|
|10666|**Custom API Ruleset Configuration**|
|10667|**Decision contract**|
|10668|**Decision rule set**|
|10669|**Rulesetentitymapping**|
|10670|**Routing diagnostic item**|
|10671|**Routing diagnostic**|
|10672|**Template Rule Set**|
|10673|**Inbox card configuration**|
|10674|**Inbox Configuration**|
|10675|**Inbox Entity Configuration**|
|10676|**App Profile Copilot Configuration**|
|10677|**Swarm**|
|10678|**Swarm participant**|
|10679|**Swarm participant rule**|
|10680|**Swarm role**|
|10681|**Swarm skill**|
|10682|**Swarm template**|
|10683|**Autonomous case creation and update rules**|
|10684|**Entity Attachment**|
|10685|**Time Tracker**|
|10686|**Customer feedback survey**|
|10687|**Customer feedback survey invite**|
|10688|**Customer feedback survey response**|
|10689|**msdyn_surveyconfig**|
|10690|**Survey setting**|
|10691|**Entity Attribute Prediction Rule**|
|10692|**Email Sentiment**|
|10693|**Master Entity Routing Configuration**|
|10694|**Routing Rule Set Setting**|
|10695|**Assignment Configuration**|
|10696|**Assignment Configuration Step**|
|10697|**Capacity Profile**|
|10698|**Overflow Action Config**|
|10699|**Preferred Agent**|
|10700|**Preferred Agent Customer Identity**|
|10701|**Preferred Agent Routed Entity**|
|10702|**Routing configuration**|
|10703|**Routing configuration step**|
|10704|**Bot Channel Registration**|
|10705|**Channel Configuration**|
|10706|**Channel State Configuration**|
|10707|**Provisioning State**|
|10708|**AdminAppState**|
|10709|**Agent Status history**|
|10710|**Power BI Configuration**|
|10711|**Authentication Settings**|
|10712|**Auth Settings Entry**|
|10713|**Quick reply**|
|10714|**Entity Routing Context**|
|10715|**Channel Capability**|
|10716|**Conversation Action**|
|10717|**Conversation Action Locale**|
|10718|**Conversation Message Block**|
|10719|**DeletedConversation**|
|10720|**Deprecated Workstream Entity Configuration**|
|10721|**Entity**|
|10722|**Ongoing conversation (Deprecated)**|
|10723|**Live work item event**|
|10724|**Work Stream**|
|10725|**Masking Rule**|
|10726|**Auto block rule**|
|10727|**Bot Channel Registration Secret**|
|10728|**Omnichannel channel api conversation privilege**|
|10729|**Omnichannel channel api message privilege**|
|10730|**Channel api method mapping**|
|10731|**External context**|
|10732|**Flagged spam**|
|10733|**Language**|
|10734|**Conversation**|
|10737|**Context item value**|
|10738|**Live Work Item Participant (Deprecated)**|
|10739|**Conversation Sentiment**|
|10740|**Context variable**|
|10741|**Localization**|
|10742|**OC Payment Profile**|
|10743|**Recording**|
|10744|**Omnichannel Request**|
|10745|**Rich message**|
|10746|**Rich message map**|
|10747|**Rule Item**|
|10748|**Sentiment daily topic**|
|10749|**Sentiment daily topic keyword**|
|10750|**Sentiment daily topic trending**|
|10751|**Session**|
|10752|**Session Participant Event**|
|10753|**Session Sentiment**|
|10754|**Message**|
|10755|**Tag**|
|10756|**Geo Location Provider**|
|10757|**Omnichannel Configuration**|
|10758|**Omnichannel Personalization**|
|10759|**Omnichannel Queue (Deprecated)**|
|10760|**Omnichannel Sync Config**|
|10761|**Operating Hour**|
|10762|**Personal quick reply**|
|10763|**Personal sound setting**|
|10764|**Persona Security Role Mapping**|
|10765|**Presence**|
|10766|**Provider**|
|10767|**RoutingRequest**|
|10768|**Search Configuration**|
|10769|**Sentiment analysis**|
|10770|**Session event**|
|10771|**Session participant**|
|10772|**Audio File**|
|10773|**Sound notification setting**|
|10774|**Transcript**|
|10775|**UR notification template**|
|10776|**UR Notification Template Mapping**|
|10777|**User settings**|
|10778|**Self service**|
|10785|**Agent capacity update history**|
|10786|**Bookable Resource Capacity Profile**|
|10787|**Work stream capacity profile**|
|10788|**Conversation Capacity profile**|
|10789|**Agent Capacity Profile Unit**|
|10790|**Agent Channel State**|
|10791|**Agent Status**|
|10792|**Agent Group**|
|10793|**Agent Group Membership**|
|10794|**Conversation Characteristic**|
|10795|**Session Characteristic**|
|10796|**Skill Attachment Rule**|
|10797|**Attach Skill**|
|10798|**Model training details**|
|10799|**Training data import configuration**|
|10800|**Characteristic mapping**|
|10801|**Training record**|
|10802|**Skill finder model**|
|10803|**Effort estimate**|
|10804|**Effort estimation model**|
|10805|**Effort model training details**|
|10806|**ConversationInsight**|
|10807|**Active ICD Extension**|
|10808|**Entity-Workstream Map**|
|10809|**ICD Extension**|
|10810|**Lock Status**|
|10811|**Omnichannel agent assignment custom api privilege**|
|10812|**Conversation Action Item**|
|10813|**Conversation Aggregated Insights**|
|10814|**Comment**|
|10815|**Conversation Participant Insights**|
|10816|**Conversation Participant Sentiment**|
|10817|**Conversation Question**|
|10818|**Conversation Segment Sentiment**|
|10819|**Conversation Sentiment**|
|10820|**Conversation Signal**|
|10821|**Conversation Subject**|
|10822|**Conversation Summary Suggestion**|
|10823|**Conversation System Tag**|
|10824|**Conversation Tag**|
|10825|**Recording (Deprecated)**|
|10826|**SCI Conversation**|
|10827|**Custom Email Highlight**|
|10828|**Custom Highlight**|
|10829|**Custom Publisher**|
|10830|**EnvironmentSettings**|
|10831|**UserSettings**|
|10832|**CatalogEventStatusConfiguration**|
|10833|**Configuration**|
|10834|**Trigger**|
|10835|**Triggers To Sdk Message Processing Steps**|
|10836|**EventParameterMetadata**|
|10837|**TrackingContext**|
|10838|**Marketing feature configuration**|
|10839|**msdynmkt_experimentv2**|
|10840|**ACS channel instance**|
|10841|**ACS channel instance account**|
|10842|**Infobip channel instance**|
|10843|**Infobip channel instance account**|
|10844|**Link mobility channel instance**|
|10845|**Link mobility channel instance account**|
|10846|**MockSmsProvider channel instance**|
|10847|**MockSmsProvider channel instance account**|
|10848|**TeleSign channel instance**|
|10849|**TeleSign channel instance account**|
|10850|**Twilio channel instance**|
|10851|**Twilio channel instance account**|
|10852|**Vibes channel instance**|
|10853|**Vibes channel instance account**|
|10854|**Predefined Placeholder**|
|10855|**Metadata Entity Relationship**|
|10856|**Metadata Item**|
|10857|**Metadata Store State**|
|10858|**DigitalSellingActiveTask**|
|10859|**DigitalSellingCompletedTask**|
|10860|**Sales Tag**|
|10861|**Sequence**|
|10862|**Sequence Stat**|
|10863|**Sequence Target**|
|10864|**Sequence Target Step**|
|10865|**Sequence Template**|
|10867|**sabackupdiagnostic**|
|10868|**SABatchRunInstance**|
|10869|**salesroutingdiagnostic**|
|10870|**SARunInstance**|
|10871|**Segment**|
|10872|**segmentsetting**|
|10873|**Segment property**|
|10874|**SegmentsUtil**|
|10875|**Assignment Rule**|
|10876|**Seller attribute**|
|10877|**Seller attribute value**|
|10878|**Assignment Map**|
|10879|**Sales Assignment Setting**|
|10880|**Sales routing run**|
|10882|**Extended User Setting**|
|10883|**Sales acceleration insights**|
|10884|**Sales Acceleration settings**|
|10885|**Insight**|
|10886|**Work List Suggestion**|
|10887|**Work list suggestion source**|
|10888|**Work List View Configuration**|
|10889|**Work Queue Record**|
|10890|**Work Queue Record State**|
|10891|**Work list user setting**|
|10892|**WQDataSource**|
|10893|**Suggestion Assignment Rule**|
|10894|**Suggestion Principal Object Access**|
|10895|**Suggestion Seller Priority**|
|10896|**Data Hygiene Setting Info**|
|10897|**Duplicate Detection Plugin Run**|
|10898|**Duplicate Lead Mapping**|
|10899|**Lead Hygiene Setting**|
|10900|**Linked Entity Attribute Validity**|
|10901|**Sales provisioning request**|
|10902|**SalesOmnichannel Message**|
|10903|**Text message template**|
|10904|**Data Analytics Admin Settings (Deprecated)**|
|10905|**Data Analytics Report**|
|10906|**Insights**|
|10907|**Sales acceleration reports**|
|10909|**Bot Session**|
|10910|**Automated action rule**|
|10911|**Automated action rules mapping**|
|10912|**Agent Copilot Setting**|
|10913|**Copilot Summarization Setting**|
|10914|**intent**|
|10915|**intentattribute**|
|10916|**intentattributeset**|
|10917|**intentattribute_entity**|
|10918|**Intent Config**|
|10919|**intententity**|
|10920|**Line of Business**|
|10921|**msdyn_intentfamily_harvestingconfiguration**|
|10922|**msdyn_intentfeature_configuration**|
|10923|**Intent Group Condition**|
|10924|**msdyn_intentharvesting_batchjobstatus**|
|10925|**msdyn_intentharvesting_batchjobstatusdetail**|
|10926|**msdyn_intentharvesting_provisioning_status**|
|10927|**Intent Solution Map**|
|10928|**msdyn_intentsolution_mappingconfiguration**|
|10929|**Case Enrichment**|
|10930|**Case follow up and closure configuration**|
|10931|**Case Suggestion**|
|10932|**Case Suggestion Request Payload**|
|10933|**Case Suggestions Data Souce**|
|10934|**Agent Preference For Copilot**|
|10935|**Copilot assisted case form fill settings**|
|10936|**Copilot Interaction**|
|10937|**Copilot Interaction Data**|
|10938|**Copilot knowledge interaction**|
|10939|**Copilot Transcript**|
|10940|**Copilot Transcript Data**|
|10941|**KB Enrichment**|
|10942|**Knowledge Article Suggestion**|
|10943|**Knowledge Article Suggestion Data Source**|
|10944|**Next Action**|
|10945|**Service Copilot Plugin**|
|10946|**Service Copilot Plugin Action**|
|10947|**Service Copilot Plugin Role**|
|10948|**Suggestion Interaction**|
|10949|**Suggestion request payload**|
|10950|**Suggestions Model Summary**|
|10951|**Suggestions Setting**|
|10952|**Data Analytics User Customized Report**|
|10953|**Data Analytics Dataset**|
|10954|**Data Analytics Workspace**|
|10955|**Report Bookmark**|
|10956|**Agent Resource Forecasting**|
|10957|**[Deprecated] Dynamics Customer Service Analytics**|
|10958|**Case Topic**|
|10959|**Case Topic Setting**|
|10960|**Case Topic Summary**|
|10961|**Case topic Incident mapping**|
|10962|**Customer Service historical analytics**|
|10963|**Forecast**|
|10964|**Knowledge analytics**|
|10965|**Model Customization analytics**|
|10966|**UR RecordRouting Real-time Analytics**|
|10967|**Forecast Summary and Setting**|
|10968|**Keywords Description Suggestion Setting**|
|10969|**Conversation Summary Interaction**|
|10970|**Conversation Summary Setting**|
|10971|**Conversation Topic**|
|10972|**Conversation Topic Setting**|
|10973|**Conversation Topic Summary**|
|10974|**Conversation topic Conversation mapping**|
|10975|**Omnichannel historical analytics**|
|10976|**Omnichannel voice historical analytics (preview) (Deprecated)**|
|10977|**Omnichannel Realtime analytics**|
|10978|**Copilot Analytics**|
|11020|**Booking Setup Metadata**|
|11021|**Client Extension**|
|11022|**Requirement Group**|
|11023|**Configuration**|
|11024|**Requirement Characteristic**|
|11025|**Bookable Resource Association**|
|11026|**Actual**|
|11027|**Three-Dimensional Model**|
|11028|**Booking Alert**|
|11029|**Booking Alert Status**|
|11030|**Booking Change**|
|11031|**Booking Rule**|
|11032|**Business Closure**|
|11033|**Organizational Unit**|
|11034|**Priority**|
|11035|**Requirement Organization Unit**|
|11036|**Requirement Relationship**|
|11037|**Requirement Resource Category**|
|11038|**Requirement Resource Preference**|
|11039|**Requirement Status**|
|11040|**Resource Requirement**|
|11041|**Resource Requirement Detail**|
|11042|**Resource Territory**|
|11043|**Schedule Board Setting**|
|11044|**Scheduling Parameter**|
|11045|**System User Scheduler Setting**|
|11046|**Fulfillment Preference**|
|11047|**Time Group Detail**|
|11048|**Transaction Origin**|
|11049|**Work Template**|
|11050|**Optimization Request**|
|11051|**Requirement Change**|
|11052|**Requirement Dependency**|
|11053|**Scheduling Feature Flag**|
|11054|**Scheduling Scope**|
|11055|**Inspection Template**|
|11056|**Inspection Attachment**|
|11057|**Inspection Template Version**|
|11058|**Inspection**|
|11059|**Inspection Response**|
|11060|**Time Entry**|
|11061|**Time Source**|
|11062|**Payment Term**|
|11063|**Purchase Order**|
|11064|**Purchase Order Product**|
|11065|**Purchase Order Receipt**|
|11066|**Purchase Order Receipt Product**|
|11067|**Ship Via**|
|11068|**Tax Code**|
|11069|**Tax Code Detail**|
|11070|**Warehouse**|
|11071|**Agreement**|
|11072|**Agreement Booking Date**|
|11073|**Agreement Booking Incident**|
|11074|**Agreement Booking Product**|
|11075|**Agreement Booking Service**|
|11076|**Agreement Booking Service Task**|
|11077|**Agreement Booking Setup**|
|11078|**Agreement Invoice Date**|
|11079|**Agreement Invoice Product**|
|11080|**Agreement Invoice Setup**|
|11081|**Agreement Substatus**|
|11082|**Booking Journal**|
|11083|**Booking Timestamp**|
|11084|**Purchase Order Business Process**|
|11085|**Case to Work Order Business Process**|
|11086|**Agreement Business Process**|
|11087|**Work Order Business Process**|
|11088|**Entitlement Application**|
|11089|**Field Service Price List Item**|
|11090|**Field Service Setting**|
|11091|**Field Service SLA Configuration**|
|11092|**Field Service System Job**|
|11093|**Incident Type**|
|11094|**Incident Type Characteristic**|
|11095|**Incident Type Product**|
|11096|**Incident Type Service**|
|11097|**Incident Type Service Task**|
|11098|**Incident Types Setup**|
|11099|**Incident Type Requirement Group**|
|11100|**Inventory Adjustment**|
|11101|**Inventory Adjustment Product**|
|11102|**Inventory Journal**|
|11103|**Inventory Transfer**|
|11104|**Order Invoicing Date**|
|11105|**Order Invoicing Product**|
|11106|**Order Invoicing Setup**|
|11107|**Order Invoicing Setup Date**|
|11108|**Payment**|
|11109|**Payment Detail**|
|11110|**Payment Method**|
|11111|**Postal Code**|
|11112|**Product Inventory**|
|11113|**Purchase Order Bill**|
|11114|**Purchase Order SubStatus**|
|11115|**Quote Booking Incident**|
|11116|**Quote Booking Product**|
|11117|**Quote Booking Service**|
|11118|**Quote Booking Service Task**|
|11119|**Quote Booking Setup**|
|11120|**Quote Invoicing Product**|
|11121|**Quote Invoicing Setup**|
|11122|**Resource Pay Type**|
|11123|**RMA**|
|11124|**RMA Product**|
|11125|**RMA Receipt**|
|11126|**RMA Receipt Product**|
|11127|**RMA SubStatus**|
|11128|**RTV**|
|11129|**RTV Product**|
|11130|**RTV Substatus**|
|11131|**Service Task Type**|
|11132|**Time Off Request**|
|11133|**Unique Number**|
|11134|**Work Order**|
|11135|**Work Order Characteristic (Deprecated)**|
|11136|**Work Order Details Generation Queue (Deprecated)**|
|11137|**Work Order Incident**|
|11138|**Work Order Product**|
|11139|**Resource Restriction (Deprecated)**|
|11140|**Work Order Service**|
|11141|**Work Order Service Task**|
|11142|**Work Order Substatus**|
|11143|**Work Order Type**|
|11145|**Bookable Resource Booking Quick Note**|
|11146|**Field Service Frontline Worker Configuration**|
|11149|**Incident Type Suggestion Result**|
|11150|**Incident Type Suggestion Run History**|
|11151|**Incident Type Resolution**|
|11152|**Insurance**|
|11153|**Not-to-exceed**|
|11154|**Asset Suggestion**|
|11155|**Problematic Asset Feedback**|
|11156|**Resolution**|
|11157|**Trade**|
|11158|**Trade Coverage**|
|11161|**Work order not-to-exceed**|
|11162|**Work Order Resolution**|
|11163|**CFS - IoT Alert Process Flow**|
|11164|**Geolocation Settings**|
|11165|**Geolocation Tracking**|
|11166|**Entity Configuration**|
|11167|**Geofence**|
|11168|**Geofence Event**|
|11169|**Geofencing Settings**|
|11170|**Asset Suggestions Setting**|
|11171|**Field service historical analytics**|
|11172|**Resource duration (preview)**|
|11173|**Predictive duration (preview)**|
|11174|**Predictive Work Hour Duration Setting**|
|11175|**Field Service Summary Configuration**|
|11176|**MobileSource**|
|11177|**Sales usage telemetry reports**|
|11178|**Sales usage reporting**|
|11179|**Derived insights related entity**|
|11180|**Entity derived insights**|
|11181|**msdyn_rawinsight**|
|11182|**msdyn_rawinsightentitylink**|
|11183|**Sales Copilot Email Insight**|
|11184|**Sales Copilot Insight Card State**|
|11185|**Email analytics**|
|11308|**LOB Backfill Status**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookingalert_sla_slaid](#BKMK_msdyn_bookingalert_sla_slaid)
- [msdyn_bookingalert_sla_slainvokedid](#BKMK_msdyn_bookingalert_sla_slainvokedid)

### <a name="BKMK_msdyn_bookingalert_sla_slaid"></a> msdyn_bookingalert_sla_slaid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_sla_slaid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msdyn_bookingalert_sla_slainvokedid"></a> msdyn_bookingalert_sla_slainvokedid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_sla_slainvokedid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.sla?displayProperty=fullName>
