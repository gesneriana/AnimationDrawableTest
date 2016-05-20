using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;

namespace AnimationDrawableTest
{
    /// <summary>
    /// 测试动画播放的测试代码
    /// </summary>
    [Activity(Label = "AnimationDrawableTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button play = FindViewById<Button>(Resource.Id.btn_paly);
            Button stop = (Button)FindViewById(Resource.Id.btn_stop);
            ImageView imageView = FindViewById<ImageView>(Resource.Id.anim);

            // 获取AnimationDrawable动画对象
            AnimationDrawable anim = (AnimationDrawable)imageView.Background;

            // 开始播放动画
            play.Click += delegate { anim.Start(); };

            // 停止播放动画
            stop.Click += delegate { anim.Stop(); };
        }
    }
}

