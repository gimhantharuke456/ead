package com.example.teaapp.service;

@kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0007\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0002\b\t\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u00a2\u0006\u0002\u0010\u0004J\u0006\u0010\u0007\u001a\u00020\bJ\u0018\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\b\b\u0002\u0010\r\u001a\u00020\nJ\u0018\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u000b\u001a\u00020\f2\b\b\u0002\u0010\r\u001a\u00020\u000fJ\u0018\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u000b\u001a\u00020\f2\b\b\u0002\u0010\r\u001a\u00020\u0011J\u0018\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u000b\u001a\u00020\f2\b\b\u0002\u0010\r\u001a\u00020\u0013J\u001c\u0010\u0014\u001a\u0004\u0018\u00010\f2\u0006\u0010\u000b\u001a\u00020\f2\n\b\u0002\u0010\r\u001a\u0004\u0018\u00010\fJ\u000e\u0010\u0015\u001a\u00020\b2\u0006\u0010\u000b\u001a\u00020\fJ\u0016\u0010\u0016\u001a\u00020\b2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\u0017\u001a\u00020\nJ\u0016\u0010\u0018\u001a\u00020\b2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\u0017\u001a\u00020\u000fJ\u0016\u0010\u0019\u001a\u00020\b2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\u0017\u001a\u00020\u0011J\u0016\u0010\u001a\u001a\u00020\b2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\u0017\u001a\u00020\u0013J\u0016\u0010\u001b\u001a\u00020\b2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\u0017\u001a\u00020\fR\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004\u00a2\u0006\u0002\n\u0000\u00a8\u0006\u001c"}, d2 = {"Lcom/example/teaapp/service/LocalPrefsService;", "", "context", "Landroid/content/Context;", "(Landroid/content/Context;)V", "sharedPreferences", "Landroid/content/SharedPreferences;", "clearAll", "", "getBoolean", "", "key", "", "defaultValue", "getFloat", "", "getInt", "", "getLong", "", "getString", "removeKey", "saveBoolean", "value", "saveFloat", "saveInt", "saveLong", "saveString", "app_debug"})
public final class LocalPrefsService {
    @org.jetbrains.annotations.NotNull
    private final android.content.SharedPreferences sharedPreferences = null;
    
    public LocalPrefsService(@org.jetbrains.annotations.NotNull
    android.content.Context context) {
        super();
    }
    
    public final void saveString(@org.jetbrains.annotations.NotNull
    java.lang.String key, @org.jetbrains.annotations.NotNull
    java.lang.String value) {
    }
    
    @org.jetbrains.annotations.Nullable
    public final java.lang.String getString(@org.jetbrains.annotations.NotNull
    java.lang.String key, @org.jetbrains.annotations.Nullable
    java.lang.String defaultValue) {
        return null;
    }
    
    public final void saveInt(@org.jetbrains.annotations.NotNull
    java.lang.String key, int value) {
    }
    
    public final int getInt(@org.jetbrains.annotations.NotNull
    java.lang.String key, int defaultValue) {
        return 0;
    }
    
    public final void saveBoolean(@org.jetbrains.annotations.NotNull
    java.lang.String key, boolean value) {
    }
    
    public final boolean getBoolean(@org.jetbrains.annotations.NotNull
    java.lang.String key, boolean defaultValue) {
        return false;
    }
    
    public final void saveLong(@org.jetbrains.annotations.NotNull
    java.lang.String key, long value) {
    }
    
    public final long getLong(@org.jetbrains.annotations.NotNull
    java.lang.String key, long defaultValue) {
        return 0L;
    }
    
    public final void saveFloat(@org.jetbrains.annotations.NotNull
    java.lang.String key, float value) {
    }
    
    public final float getFloat(@org.jetbrains.annotations.NotNull
    java.lang.String key, float defaultValue) {
        return 0.0F;
    }
    
    public final void removeKey(@org.jetbrains.annotations.NotNull
    java.lang.String key) {
    }
    
    public final void clearAll() {
    }
}