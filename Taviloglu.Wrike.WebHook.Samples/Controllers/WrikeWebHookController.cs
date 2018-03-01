﻿using Microsoft.AspNetCore.Mvc;
using System;
using Taviloglu.Wrike.Core;

namespace Taviloglu.Wrike.WebHook.Samples.Controllers
{
    [Route("api/[controller]")]
    public class WrikeWebHookController : WrikeWebHookControllerBase
    {
        protected override void OnError(Exception ex)
        {
            //TODO: might wanna log exception here
        }

        protected override void OnAttachmentAdded(WrikeWebHookAttachmentEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnAttachmentDeleted(WrikeWebHookAttachmentEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnCommentAdded(WrikeWebHookCommentEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnCommentDeleted(WrikeWebHookCommentEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnTaskCreated(WrikeWebHookEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnTaskDatesChanged(WrikeWebHookTaskDatesChangedEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnTaskDeleted(WrikeWebHookEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnTaskDescriptionChanged(WrikeWebHookEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnTaskImportanceChanged(WrikeWebHookTaskImportanceChangedEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnTaskParentsAdded(WrikeWebHookEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnTaskParentsRemoved(WrikeWebHookEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnTaskResponsiblesAdded(WrikeWebHookTaskResponsiblesAddedEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnTaskResponsiblesRemoved(WrikeWebHookEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnTaskSharedsAdded(WrikeWebHookTaskSahredsAddedEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnTaskSharedsRemoved(WrikeWebHookEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnTaskStatusChanged(WrikeWebHookTaskStatusChangedEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnTaskTitleChanged(WrikeWebHookTaskTitleChangedEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }

        protected override void OnTimelogChanged(WrikeWebHookEvent wrikeWebHookEvent)
        {
            //TODO: write some code
        }
    }
}
