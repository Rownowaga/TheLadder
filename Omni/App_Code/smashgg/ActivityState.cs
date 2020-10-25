using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public enum ActivityState
    {
        CREATED,
        //Activity is created

        ACTIVE,
        //Activity is active or in progress

        COMPLETED,
        //Activity is done

        READY,
        //Activity is ready to be started

        INVALID,
        //Activity is invalid

        CALLED,
        //Activity, like a set, has been called to start

        QUEUED
        //Activity is queued to run
    }
}