package com.example.teaapp.service;

@kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u00c6\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002\u00a2\u0006\u0002\u0010\u0002J\u0019\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H\u0086@\u00f8\u0001\u0000\u00a2\u0006\u0002\u0010\u0012J\u0019\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u0016H\u0086@\u00f8\u0001\u0000\u00a2\u0006\u0002\u0010\u0017J\u0019\u0010\u0018\u001a\u00020\u000f2\u0006\u0010\u0019\u001a\u00020\u000fH\u0086@\u00f8\u0001\u0000\u00a2\u0006\u0002\u0010\u001aR\u001b\u0010\u0003\u001a\u00020\u00048BX\u0082\u0084\u0002\u00a2\u0006\f\n\u0004\b\u0007\u0010\b\u001a\u0004\b\u0005\u0010\u0006R\u001b\u0010\t\u001a\u00020\n8BX\u0082\u0084\u0002\u00a2\u0006\f\n\u0004\b\r\u0010\b\u001a\u0004\b\u000b\u0010\f\u0082\u0002\u0004\n\u0002\b\u0019\u00a8\u0006\u001b"}, d2 = {"Lcom/example/teaapp/service/UserService;", "", "()V", "retrofit", "Lretrofit2/Retrofit;", "getRetrofit", "()Lretrofit2/Retrofit;", "retrofit$delegate", "Lkotlin/Lazy;", "userApi", "Lcom/example/teaapp/service/UserApi;", "getUserApi", "()Lcom/example/teaapp/service/UserApi;", "userApi$delegate", "getProfile", "Lcom/example/teaapp/model/User;", "userId", "", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "register", "Lcom/example/teaapp/dto/RegisterResponse;", "request", "Lcom/example/teaapp/dto/RegisterRequest;", "(Lcom/example/teaapp/dto/RegisterRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "updateProfile", "user", "(Lcom/example/teaapp/model/User;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "app_debug"})
public final class UserService {
    @org.jetbrains.annotations.NotNull
    private static final kotlin.Lazy retrofit$delegate = null;
    @org.jetbrains.annotations.NotNull
    private static final kotlin.Lazy userApi$delegate = null;
    @org.jetbrains.annotations.NotNull
    public static final com.example.teaapp.service.UserService INSTANCE = null;
    
    private UserService() {
        super();
    }
    
    private final retrofit2.Retrofit getRetrofit() {
        return null;
    }
    
    private final com.example.teaapp.service.UserApi getUserApi() {
        return null;
    }
    
    @org.jetbrains.annotations.Nullable
    public final java.lang.Object register(@org.jetbrains.annotations.NotNull
    com.example.teaapp.dto.RegisterRequest request, @org.jetbrains.annotations.NotNull
    kotlin.coroutines.Continuation<? super com.example.teaapp.dto.RegisterResponse> $completion) {
        return null;
    }
    
    @org.jetbrains.annotations.Nullable
    public final java.lang.Object getProfile(@org.jetbrains.annotations.NotNull
    java.lang.String userId, @org.jetbrains.annotations.NotNull
    kotlin.coroutines.Continuation<? super com.example.teaapp.model.User> $completion) {
        return null;
    }
    
    @org.jetbrains.annotations.Nullable
    public final java.lang.Object updateProfile(@org.jetbrains.annotations.NotNull
    com.example.teaapp.model.User user, @org.jetbrains.annotations.NotNull
    kotlin.coroutines.Continuation<? super com.example.teaapp.model.User> $completion) {
        return null;
    }
}