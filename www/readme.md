# Cron for certbot
crontab -e
```
59 10 * * * docker compose run --rm certbot renew > /root/cron.log 2>&1
```
