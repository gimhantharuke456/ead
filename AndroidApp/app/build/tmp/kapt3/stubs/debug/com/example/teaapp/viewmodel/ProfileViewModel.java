package com.example.teaapp.viewmodel;

@kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0005\u00a2\u0006\u0002\u0010\u0002J\u000e\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rJ\u000e\u0010\u000e\u001a\u00020\u000b2\u0006\u0010\u000f\u001a\u00020\u0010R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004X\u0082\u0004\u00a2\u0006\u0002\n\u0000R\u0017\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00050\u0007\u00a2\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t\u00a8\u0006\u0011"}, d2 = {"Lcom/example/teaapp/viewmodel/ProfileViewModel;", "Landroidx/lifecycle/ViewModel;", "()V", "_profileState", "Landroidx/lifecycle/MutableLiveData;", "Lcom/example/teaapp/viewmodel/ProfileState;", "profileState", "Landroidx/lifecycle/LiveData;", "getProfileState", "()Landroidx/lifecycle/LiveData;", "fetchProfile", "", "userId", "", "updateProfile", "user", "Lcom/example/teaapp/model/User;", "app_debug"})
public final class ProfileViewModel extends androidx.lifecycle.ViewModel {
    @org.jetbrains.annotations.NotNull
    private final androidx.lifecycle.MutableLiveData<com.example.teaapp.viewmodel.ProfileState> _profileState = null;
    @org.jetbrains.annotations.NotNull
    private final androidx.lifecycle.LiveData<com.example.teaapp.viewmodel.ProfileState> profileState = null;
    
    public ProfileViewModel() {
        super();
    }
    
    @org.jetbrains.annotations.NotNull
    public final androidx.lifecycle.LiveData<com.example.teaapp.viewmodel.ProfileState> getProfileState() {
        return null;
    }
    
    public final void fetchProfile(@org.jetbrains.annotations.NotNull
    java.lang.String userId) {
    }
    
    public final void updateProfile(@org.jetbrains.annotations.NotNull
    com.example.teaapp.model.User user) {
    }
}