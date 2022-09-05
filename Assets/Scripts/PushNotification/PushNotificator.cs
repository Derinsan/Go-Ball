using UnityEngine;
using Unity.Notifications.Android;

public class PushNotificator : MonoBehaviour
{
    private void Awake()
    {
        AndroidNotificationChannel channel = new AndroidNotificationChannel()
        {
            Name = "News | Новости",
            Description = "Уведомления о новостях игры",
            Id = "news",
            Importance = Importance.High,
        };

        AndroidNotificationCenter.RegisterNotificationChannel(channel);
    }

    public void SendNotification()
    {
        AndroidNotification notification = new AndroidNotification()
        {
            Title = "Go Ball",
            Text = "Пришло время побивать новые рекорды!",
            FireTime = System.DateTime.Now.AddHours(24),
            SmallIcon = "icon_1",
            LargeIcon = "icon_0",
        };

        AndroidNotificationCenter.SendNotification(notification, channelId: "news");
    }
}
