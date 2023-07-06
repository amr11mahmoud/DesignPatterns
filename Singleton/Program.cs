using Singleton;

Logger logger1 = Logger.Instance;
Logger logger2 = Logger.Instance;

if (logger1 == logger2)
{
    logger2.Log("same");
}

logger1.Log("hello from logger1");
logger2.Log("hello from logger2");