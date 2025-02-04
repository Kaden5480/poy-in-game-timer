namespace InGameTimer {
    public class SceneState {
        public SceneInfo info { get; }
        public bool completed;

        public SceneState(SceneInfo info) {
            this.info = info;
            this.completed = false;
        }
    }
}
